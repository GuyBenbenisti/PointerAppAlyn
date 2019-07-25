import numpy as np
import argparse
import cv2 as cv
import subprocess
import time
import os
import json
import requests
from PIL import Image
import pyttsx3
import playsound
# from pygame import mixer
# from pydub import AudioSegment
# from pydub.playback import play
# import vlc
import os


def infer_image_azure(temp_path, frame):
    # save to file
    image_url = temp_path + "image.jpeg"
    cv.imwrite(image_url, frame)

    # use azure cognitive services to infer
    subscription_key = "e6958ea76a854f5bbefa34ee50a27c86"
    assert subscription_key

    vision_base_url = "https://westeurope.api.cognitive.microsoft.com/vision/v2.0/"

    analyze_url = vision_base_url + "analyze"

    headers = {'Ocp-Apim-Subscription-Key': subscription_key}
    params = {'visualFeatures': 'Objects'}
    files = {'upload_file': open(image_url, 'rb')}
    response = requests.post(analyze_url, headers=headers, params=params, files=files)
    response.raise_for_status()

    analysis = response.json()
    print(json.dumps(response.json()))
    for i in range(len(analysis["objects"])):
        1
        # print("object" + str(i) + ": " + analysis["objects"][i]["object"])
        # if i == 0:
        #     engine = pyttsx3.init()
        #     engine.say(analysis["objects"][i]["object"])
        #     engine.runAndWait()

    with open(temp_path + 'data.json', 'w') as f:
        json.dump(analysis, f)

    return analysis


def text_to_speech_yolo(boxes, confidences, classids, idxs, labels, img, FLAGS):
    height, width = img.shape[:2]
    if len(classids) > 0:
        predicted_labels = [labels[ii] for ii in classids]
        min_box = boxes[0][2]*boxes[0][3]
        object_to_speech_module = predicted_labels[0]
        object_valid_flag = False
        for (box_id, box_array) in enumerate(boxes):
            curr_x_min = box_array[0] # orig x
            curr_y_min = box_array[1] # orig y
            curr_x_max = box_array[0] + box_array[2]
            curr_y_max = box_array[1]  + box_array[3]
            if FLAGS.tobii_x_pos == -999:
                tobii_x_y_flag = True
            else:              
                tobii_x_y_flag = ((FLAGS.tobii_x_pos * width >= curr_x_min and FLAGS.tobii_x_pos * width <= curr_x_max) and (FLAGS.tobii_y_pos * height >= curr_y_min and FLAGS.tobii_y_pos * height <= curr_y_max))
            if tobii_x_y_flag:
                if (box_array[2]*box_array[3]) <= min_box:
                    object_to_speech_module = predicted_labels[box_id]
                    object_valid_flag = True
        # print("smallest object in captured frame: " + object_to_speech_module)

        if (object_valid_flag):
            project_root_folder = FLAGS.project_root
            tts_folder = os.path.join(project_root_folder, 'sound_files/tts/TTS_' + FLAGS.speech_language)
            # tts_folder = r"C:/Users/taaviv/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/sound_files/tts/TTS_" + speech_language
            tts_file = os.path.join(tts_folder, object_to_speech_module + ".wav")
            # print(tts_file)
            playsound.playsound(tts_file)
        print('python_cycle_finished')


def show_image(img):
    cv.imshow("Image", img)
    cv.waitKey(0)


def draw_labels_and_boxes(img, boxes, confidences, classids, idxs, colors, labels):
    # If there are any detections
    if len(idxs) > 0:
        for i in idxs.flatten():
            # Get the bounding box coordinates
            x, y = boxes[i][0], boxes[i][1]
            w, h = boxes[i][2], boxes[i][3]
            
            # Get the unique color for this class
            color = [int(c) for c in colors[classids[i]]]

            # Draw the bounding box rectangle and label on the image
            cv.rectangle(img, (x, y), (x+w, y+h), color, 2)
            text = "{}: {:4f}".format(labels[classids[i]], confidences[i])
            cv.putText(img, text, (x, y-5), cv.FONT_HERSHEY_SIMPLEX, 0.5, color, 2)

    return img


def generate_boxes_confidences_classids(outs, height, width, tconf):
    boxes = []
    confidences = []
    classids = []

    for out in outs:
        for detection in out:
            #print (detection)
            #a = input('GO!')
            
            # Get the scores, classid, and the confidence of the prediction
            scores = detection[5:]
            classid = np.argmax(scores)
            confidence = scores[classid]
            
            # Consider only the predictions that are above a certain confidence level
            if confidence > tconf:
                # TODO Check detection
                box = detection[0:4] * np.array([width, height, width, height])
                centerX, centerY, bwidth, bheight = box.astype('int')

                # Using the center x, y coordinates to derive the top
                # and the left corner of the bounding box
                x = int(centerX - (bwidth / 2))
                y = int(centerY - (bheight / 2))

                # Append to list
                boxes.append([x, y, int(bwidth), int(bheight)])
                confidences.append(float(confidence))
                classids.append(classid)

    return boxes, confidences, classids

def print_json_to_terminal(boxes, confidences, classids, idxs, labels, print_en):
    if print_en:
        predicted_labels = [labels[ii] for ii in classids]
        a = {"boxes": boxes, "confidences": confidences, "predicted_labels": predicted_labels, "idxs": idxs}
        # b = json.dumps(a)
        print(a)
        print("#")

def infer_image(net, layer_names, height, width, img, colors, labels, FLAGS, 
            boxes=None, confidences=None, classids=None, idxs=None, infer=True):
    
    if infer:
        # Contructing a blob from the input image
        blob = cv.dnn.blobFromImage(img, 1 / 255.0, (416, 416), 
                        swapRB=True, crop=False)

        # Perform a forward pass of the YOLO object detector
        net.setInput(blob)

        # Getting the outputs from the output layers
        start = time.time()
        outs = net.forward(layer_names)
        end = time.time()

        if FLAGS.show_time:
            print ("[INFO] YOLOv3 took {:6f} seconds".format(end - start))

        
        # Generate the boxes, confidences, and classIDs
        boxes, confidences, classids = generate_boxes_confidences_classids(outs, height, width, FLAGS.confidence)
        
        # Apply Non-Maxima Suppression to suppress overlapping bounding boxes
        idxs = cv.dnn.NMSBoxes(boxes, confidences, FLAGS.confidence, FLAGS.threshold)

    if boxes is None or confidences is None or idxs is None or classids is None:
        raise '[ERROR] Required variables are set to None before drawing boxes on images.'
        
    # Draw labels and boxes on the image
    img = draw_labels_and_boxes(img, boxes, confidences, classids, idxs, colors, labels)

    return img, boxes, confidences, classids, idxs
