using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_2
{
    interface IDocument
    {
        string FileExtension { get; set;}
        string FileName { get; set; }
       
    }
}
