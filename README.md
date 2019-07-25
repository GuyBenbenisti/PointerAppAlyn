**Pointer App &amp; HW:**

**Current status:**

We have an app that plays video from a defined camera and a when the eyetracker identifies a gaze it runs object detection on that frame and reads the name of the object detected in the defined language.

1. All the code is in the following repo: [https://github.com/GuyBenbenisti/PointerAppAlyn](https://github.com/GuyBenbenisti/PointerAppAlyn)
2. Installations:

-
  - Tobii eyetracker - [https://gaming.tobii.com/getstarted/](https://gaming.tobii.com/getstarted/)
  - Visual studio – add the tobii.interaction reference through package manager. Set the manager as StartUp Project and run it.
  - Anaconda: in the environment pip install
    - opencv-python
    - playsound
    - pyttsx3
  - download yolo weights file from the web - [https://pjreddie.com/darknet/yolo/](https://pjreddie.com/darknet/yolo/)

3. Edit the paths in the configurations file in the manager folder – app.config. you need to insert the correct anaconda path and the project&#39;s path. If there is any problem with the paths – edit it in the Harness.cs file.
4. running only the python code for object detection is also an option:

image reference:
\*\*python path\*\*\python.exe  \*\*repo path\*\*\YOLOv3-Object-Detection-with-OpenCV\yolo.py -i \*\*repo path\*\*/YOLOv3-Object-Detection-with-OpenCV/temp/image.jpeg

Web cam:
\*\*python path\*\*\python.exe  \*\*repo path\*\*\PointerAppAlyn\YOLOv3-Object-Detection-with-OpenCV\yolo.py


**Known Gaps and Future Work:**

1. speed optimizations – improve the running time of Tobii, UI and Yolo.
2. Object detection - the number of classes in the YoloV3 object detection is currently limited to 80. Consider using a model with more classes.
3. Azure cognitive services - It is possible to replace the offline translation and text to speech and the yolo object detection with online cloud Azure cognitive services
4. Buttons - add their functionality
5. wrap all code to some executable easy to run
