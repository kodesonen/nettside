from PIL import Image
import PIL
import os
import glob
import sys
import configparser

class Compression:

    def __init__(self):
        config = configparser.ConfigParser()
        config.read('settings.ini')

        self.pathRoot = config.get('settings','root_path')
        self.folders = config.get('settings', 'folders').split()
        self.formats = config.get('settings', 'formats').split()

    def GetFolders(self):
        return self.folders

    def ResizeImg(self, basewidth, img):
        wpercent = (basewidth / float(img.size[0]))
        hsize = int((float(img.size[1]) * float(wpercent)))

        img = img.resize((basewidth, hsize), Image.ANTIALIAS)
        return img

    def Compressing(self, specifyImg, directoryPath):

        if directoryPath == "uploads":
            path = self.pathRoot + 'uploads/'
            quality = 30
            basewidth = 500
        elif directoryPath == "team":
            path = self.pathRoot + 'team/'
            quality = 30
            basewidth = 250
        else:
            print("Path to directory does not exist!")

        os.chdir(path)
        files = os.listdir()

        if not specifyImg:
            images = [file for file in files if file.endswith(('jpg', 'png', 'jpeg'))]

            for image in images:
                img = Image.open(image)
                img = self.ResizeImg(basewidth, img)

                img.save(image, optimize = True, quality = quality)

        else:
            image = Image.open(specifyImg)
            image = self.ResizeImg(basewidth, image)
            
            image.save(specifyImg, optimize = True, quality = quality)


start = Compression()
folders = start.GetFolders()

start.Compressing("", "uploads")

#if sys.argv[0] == "build":
#    for folder in folders:
#        start.Compressing("", folder)
#else:
#    start.Compressing(sys.argv[0], "upload")
