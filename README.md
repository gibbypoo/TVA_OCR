# TVA_OCR
Potential TVA OCR solution using Tesseract 

This repo demonstrates the Tesseract OCR engine (https://github.com/tesseract-ocr/tesseract). 
k
I've included several pictures of UNID tags that were sent to me:
1. myTag.jpg
2. tag1.jpg
3. tag2.jpg
4. tag3.jpg
5. shinyPic.jpg (from nuke site)

Basic command line usage:

tesseract imagename outputbase [-l lang] [--psm pagesegmode] [configfiles...]
For more information about the various command line options use tesseract --help or man tesseract.

Example: tesseract myTag.jpg output

This will take in the myTag.jpg image, put it through the OCR engine and spit out the result into the output file

I've also included a simple command line application that does this same thing but outputs the result instead of having to open the output text file on each run
