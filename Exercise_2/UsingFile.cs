using System;
using System.IO;

namespace Exercise_2
{
    class UsingFile
    {
        AbstractHandler handler;
        public string FileExtension { get; set; }
        public string FilePath { get; set; }

        public UsingFile(string filepath)
        {
            FilePath = filepath;
            FileExtension = Extension();
        }

        public void ChoosFile()
        {
            
            switch (FileExtension)
            {
                case ".txt": 
                    handler = new TXTHandler(FilePath);
                    Open();
                    Create();
                    Change();
                    Save();
                    break;
                case ".xml":
                    handler = new XMLHandler(FilePath);
                    Open();
                    Create();
                    Change();
                    Save();
                    break;
                case ".doc":
                    handler = new DOCHandler(FilePath);
                    Open();
                    Create();
                    Change();
                    Save();
                    break;
                default: Console.WriteLine("Такого файла не существует");
                    break;
            }

        }

        #region Метод определения расширения
        public string Extension()
        {
            FileExtension = Path.GetExtension(FilePath);
            return FileExtension;
        }
        #endregion

        #region Методы управления файлами
        public void Open()
        {
            handler.Open();
        }

        public void Create()
        {
            handler.Create();
        }

        public void Change()
        {
            handler.Change();
        }

        public void Save()
        {
            handler.Save();
        }
        #endregion
    }
}
