using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management.Automation;
using System.Collections.ObjectModel;

namespace SimpleOCRWithCMDLine
{
    class Program
    {
        static void Main(string[] args)
        {
            //Run the tesseract job to OCR the picture
            System.Environment.CurrentDirectory = @"C:\Users\tabowma0\Desktop\Tesseract-OCR";

            //myTag.jpg, tag1.jpg, tag2.jpg, tag3.jpg, shinyPic.jpg
            System.Diagnostics.Process.Start("tesseract", "myTag.jpg output");

            string UNID;        

            //Read the file and save the UNID
            using (System.IO.StreamReader file = new System.IO.StreamReader("C:\\Users\\tabowma0\\Desktop\\Tesseract-OCR\\output.txt"))
            {
                //UNID = file.ReadLine() ?? "";
                while ((UNID = file.ReadLine())!=null)
                {
                    if (UNID != "" && UNID != " ")
                    {
                        Console.WriteLine(UNID);
                    }
                }
            }

            Console.ReadLine();
        }
    }
}
