using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    class Document : AbstractDocument
    {
        string title_content = null;
        string body_content = null;
        string footer_content = null;
        public override string TitleContent 
        { 
            get 
            {
                if (title_content != null)
                    return title_content;
                else
                    return "Заголовок отсутствует.";
            }
            set 
            {
                title_content = value;
            }
        }
        public override string BodyContent 
        {
            get
            {
                if (body_content != null)
                    return body_content;
                else
                    return "Тело документа отсутствует.";
            }
            set
            {
                body_content = value;
            }
        }
        public override string FooterContent 
        {
            get
            {
                if (footer_content != null)
                    return footer_content;
                else
                    return "Нижний колонтитул отсутствует.";
            }
            set
            {
                footer_content = value;
            }
        }

        public Document(string title_content, string body_content, string footer_content)
        {
            this.title_content = title_content;
            this.body_content = body_content;
            this.footer_content = footer_content;
        }

        public override (string, string, string) CreateDocument()
        {
            var document = (TitleContent, BodyContent, FooterContent);
            return document;
        }

        public override void PrintDocument(string title_content, string body_content, string footer_content)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(title_content);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(body_content);
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(footer_content);
            Console.ForegroundColor = ConsoleColor.Gray;
        }
    }
}
