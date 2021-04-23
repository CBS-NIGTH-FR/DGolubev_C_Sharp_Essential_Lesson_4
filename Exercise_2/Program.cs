using System;
using System.IO;


namespace Exercise_2
{
    class Program
    {
        
        static void Main(string[] args)
        {
            
            Console.WriteLine("Введите путь к файлу");
            string path = Path.GetFullPath( Console.ReadLine());
            UsingFile file = new UsingFile(path);
            file.ChoosFile();
            Console.ReadKey();
        }

       
              
    }
}
