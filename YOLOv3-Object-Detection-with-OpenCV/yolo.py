import numpy as np
import argparse
import cv2 as cv
import subprocess
import time
import os
from yolo_utils import infer_image, show_image, print_json_to_terminal, infer_image_azure, text_to_speech_yolo
import json

import requests
from PIL import Image
from io import BytesIO
subscription_key = "e6958ea76a854f5bbefa34ee50a27c86"

assert subscription_key
vision_base_url = "https://vision-sdk.cognitiveservices.azure.com/"

FLAGS = []

if __name__ == '__main__':
	parser = argparse.ArgumentParser()

	parser.add_argument('-m', '--model-path',
		type=str,
		default='./yolov3-coco/',
		help='The directory where the model weights and \
			  configuration files are.')

	parser.add_argument('-w', '--weights',
		type=str,
		default='./yolov3-coco/yolov3.weights',
		help='Path to the file which contains the weights \
			 	for YOLOv3.')

	parser.add_argument('-cfg', '--config',
		type=str,
		default='./yolov3-coco/yolov3.cfg',
		help='Path to the configuration file for the YOLOv3 model.')

	parser.add_argument('-i', '--image-path',
		type=str,
		help='The path to the image file')

	parser.add_argument('-v', '--video-path',
		type=str,
		help='The path to the video file')


	parser.add_argument('-vo', '--video-output-path',
		type=str,
        default='./output.avi',
		help='The path of the output video file')

	parser.add_argument('-l', '--labels',
		type=str,
		default='./yolov3-coco/coco-labels',
		help='Path to the file having the \
					labels in a new-line seperated way.')

	parser.add_argument('-c', '--confidence',
		type=float,
		default=0.5,
		help='The model will reject boundaries which has a \
				probabiity less than the confidence value. \
				default: 0.5')

	parser.add_argument('-th', '--threshold',
		type=float,
		default=0.3,
		help='The threshold to use when applying the \
				Non-Max Suppresion')

	parser.add_argument('--download-model',
		type=bool,
		default=False,
		help='Set to True, if the model weights and configurations \
				are not present on your local machine.')

	parser.add_argument('-t', '--show-time',
		type=bool,
		default=False,
		help='Show the time taken to infer each image.')

	parser.add_argument('-x', '--tobii-x-pos',
		type=float,
		default=-999,
		help='tobii-gaze-x-position.')

	parser.add_argument('-y', '--tobii-y-pos',
		type=float,
		default=-999,
		help='tobii-gaze-y-position.')

	parser.add_argument('-ln', '--speech-language',
		type=str,
		default='HE',
		help='specify speech language: HE/AR')

	FLAGS, unparsed = parser.parse_known_args()

	# Download the YOLOv3 models if needed
	if FLAGS.download_model:
		subprocess.call(['./yolov3-coco/get_model.sh'])

	# Get the labels
	print(FLAGS.labels)
	print(os.getcwd())
	labels = open(FLAGS.labels).read().strip().split('\n')

	# Intializing colors to represent each label uniquely
	colors = np.random.randint(0, 255, size=(len(labels), 3), dtype='uint8')

	# Load the weights and configutation to form the pretrained YOLOv3 model
	net = cv.dnn.readNetFromDarknet(FLAGS.config, FLAGS.weights)

	# Get the output layer names of the model
	layer_names = net.getLayerNames()
	layer_names = [layer_names[i[0] - 1] for i in net.getUnconnectedOutLayers()]
        
	# If both image and video files are given then raise error
	if FLAGS.image_path is None and FLAGS.video_path is None:
	    print ('Neither path to an image or path to video provided')
	    print ('Starting Inference on Webcam')

	# Do inference with given image
	if FLAGS.image_path:
		# Read the image
		try:
			img = cv.imread(FLAGS.image_path)
			height, width = img.shape[:2]
		except:
			raise 'Image cannot be loaded!\n\
                               Please check the path provided!'

		finally:
			FLAGS.project_root = FLAGS.image_path[0:FLAGS.image_path.find('temp')]

			# img, _, _, _, _ = infer_image(net, layer_names, height, width, img, colors, labels, FLAGS)
			# show_image(img)

			frame, boxes, confidences, classids, idxs = infer_image(net, layer_names, \
								height, width, img, colors, labels, FLAGS)
			
			text_to_speech_yolo(boxes, confidences, classids, idxs, labels, img, FLAGS)

	elif FLAGS.video_path:
		# Read the video
		try:
			vid = cv.VideoCapture(FLAGS.video_path)
			height, width = None, None
			writer = None
		except:
			raise 'Video cannot be loaded!\n\
                               Please check the path provided!'

		finally:
			while True:
				grabbed, frame = vid.read()

			    # Checking if the complete video is read
				if not grabbed:
					break

				if width is None or height is None:
					height, width = frame.shape[:2]

				frame, _, _, _, _ = infer_image(net, layer_names, height, width, frame, colors, labels, FLAGS)

				if writer is None:
					# Initialize the video writer
					fourcc = cv.VideoWriter_fourcc(*"MJPG")
					writer = cv.VideoWriter(FLAGS.video_output_path, fourcc, 30, 
						            (frame.shape[1], frame.shape[0]), True)


				writer.write(frame)

			print ("[INFO] Cleaning up...")
			writer.release()
			vid.release()


	else:
		# Infer real-time on webcam
		count = 0

		vid = cv.VideoCapture(0)
		# vid.set(cv.CAP_PROP_FRAME_WIDTH, 320)
		# vid.set(cv.CAP_PROP_FRAME_HEIGHT, 240)

		while True:
			_, frame = vid.read()
			# frame = cv.resize(frame, (320,240))
			# frame = cv.resize(frame, (320,320))	

			height, width = frame.shape[:2]

			if count == 0:
				FLAGS.project_root = 'C:/Users/taaviv/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV'

				# print("frame: " + str(frame))
				frame, boxes, confidences, classids, idxs = infer_image(net, layer_names, \
		    						height, width, frame, colors, labels, FLAGS)
				
				# azure_vision_json = infer_image_azure("C:/Users/taaviv/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/temp/", frame)
				# azure_speech_json = infer_speech_azure(frame)

				# print_json_to_terminal(boxes, confidences, classids, idxs, labels, print_en=1)

				text_to_speech_yolo(boxes, confidences, classids, idxs, labels, frame, FLAGS)

    			# save to file
				cv.imwrite(os.path.join(FLAGS.project_root, 'temp/image.jpeg'), frame)

				count += 1
			else:
				frame, boxes, confidences, classids, idxs = infer_image(net, layer_names, \
		    						height, width, frame, colors, labels, FLAGS, boxes, confidences, classids, idxs, infer=False)
				# count = (count + 1) % 6
				count = (count + 1) % 60

			cv.imshow('webcam', frame)

			if cv.waitKey(1) & 0xFF == ord('q'):
				break
		vid.release()
		cv.destroyAllWindows()
