import requests
# If you are using a Jupyter notebook, uncomment the following line.
# %matplotlib inline
import matplotlib.pyplot as plt
import json
from PIL import Image
from io import BytesIO

# Replace <Subscription Key> with your valid subscription key.
subscription_key = "e6958ea76a854f5bbefa34ee50a27c86"
assert subscription_key

# You must use the same region in your REST call as you used to get your
# subscription keys. For example, if you got your subscription keys from
# westus, replace "westcentralus" in the URI below with "westus".
#
# Free trial subscription keys are generated in the "westcentralus" region.
# If you use a free trial subscription key, you shouldn't need to change
# this region.
vision_base_url = "https://westeurope.api.cognitive.microsoft.com/vision/v2.0/"
# vision_base_url = "https://vision-sdk.cognitiveservices.azure.com/"

analyze_url = vision_base_url + "analyze"

# Set image_url to the URL of an image that you want to analyze.
# image_url = "https://upload.wikimedia.org/wikipedia/commons/thumb/1/12/" + \
    # "Broadway_and_Times_Square_by_night.jpg/450px-Broadway_and_Times_Square_by_night.jpg"
image_url = "C:/Users/taaviv/PointerAppAlyn/YOLOv3-Object-Detection-with-OpenCV/450px-Broadway_and_Times_Square_by_night.jpg"

headers = {'Ocp-Apim-Subscription-Key': subscription_key}
# params = {'visualFeatures': 'Categories,Description,Color'}
params = {'visualFeatures': 'Objects'}
data = {'url': image_url}
files = {'upload_file': open(image_url, 'rb')}
# response = requests.post(analyze_url, headers=headers,
#                          params=params, json=data)
response = requests.post(analyze_url, headers=headers,
                         params=params, files=files)
response.raise_for_status()

# The 'analysis' object contains various fields that describe the image. The most
# relevant caption for the image is obtained from the 'description' property.
analysis = response.json()
print(json.dumps(response.json()))
# image_caption = analysis["description"]["captions"][0]["text"].capitalize()
image_caption = 'bla'

# Display the image and overlay it with the caption.
# image = Image.open(BytesIO(requests.get(image_url).content))
image = Image.open(image_url)
plt.imshow(image)
plt.axis("off")
_ = plt.title(image_caption, size="x-large", y=-0.1)
plt.show()