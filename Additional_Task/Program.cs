using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите титул документа");
            string title = Console.ReadLine();
            Console.WriteLine("Введите содержание документа");
            string body = Console.ReadLine();
            Console.WriteLine("Введите нижний колонтитул документа");
            string footer = Console.ReadLine();
            Document document = new Document(title, body, footer);
            var my_document = document.CreateDocument();
            Console.WriteLine(new string('-', 25) + " " +"Сформированный документ"+ new string('-', 25));
            document.PrintDocument(my_document.Item1, my_document.Item2, my_document.Item3);
            Console.ReadKey();
        }

    }
}
