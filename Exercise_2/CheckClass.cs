using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    class CheckClass
    {
        DOCHandler DOC_Handler;
        TXTHandler TXT_Handler;
        XMLHandler XML_Handler;
        public string FileExtension { get; set; }
        public string FileName { get; set; }

        public CheckClass(string fullpath)
        {
            FileName = fullpath;
            FileExtension = Extension(FileName);
        }
        public string Extension(string filename)
        {
            string extension;
            extension = Path.GetExtension(filename);
            return extension;
        }
        public void NewClass()
        {
            if (!File.Exists(FileName)) 
            {
                Console.WriteLine("Файл не найден");
                return;
            }
            else
            {
                if (FileExtension == ".doc")
                {
                    DOC_Handler = new DOCHandler(FileName);
                    DOC_Handler.Change();
                    DOC_Handler.Create();
                    DOC_Handler.Open();
                    DOC_Handler.Save();

                }
                else if (FileExtension == ".txt")
                {
                    TXT_Handler = new TXTHandler();
                    TXT_Handler.Change();
                    TXT_Handler.Create();
                    TXT_Handler.Open();
                    TXT_Handler.Save();
                }
                else if (FileExtension == ".xml")
                {
                    XML_Handler = new XMLHandler();
                    XML_Handler.Change();
                    XML_Handler.Create();
                    XML_Handler.Open();
                    XML_Handler.Save();
                }
            }
        }
    }
}
