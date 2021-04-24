using System;


namespace Exercise_2
{
    class DOCHandler : AbstractHandler
    {
        public override string FilePath { get; set; }

        public DOCHandler(string filepath)
            : base(filepath) {}                 //Отлично

              
        public override void Save()
        {
            Console.WriteLine($"class DOCHandler : Cохранен Файл {FilePath}");
        }

        public override void Open()
        {
            Console.WriteLine($"class DOCHandler : Открыт файл {FilePath}");
        }

        public override void Create()
        {
            Console.WriteLine($"class DOCHandler : Создан файл {FilePath}");
        }

        public override void Change()
        {
            Console.WriteLine($"class DOCHandler : Изменен файл {FilePath}");
        }
    }
}
