using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Additional_Task
{
    abstract class AbstractDocument
    {
        public abstract string TitleContent { get; set; }
        public abstract string BodyContent { get; set; }
        public abstract string FooterContent { get; set; }


        public abstract (string, string, string) CreateDocument();
        public abstract void PrintDocument(string title_content, string body_content, string footer_content);
        
    }
}
