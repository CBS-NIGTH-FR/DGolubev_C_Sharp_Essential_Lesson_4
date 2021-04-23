using System;


namespace Exercise_2
{
    abstract class AbstractHandler
    {
        
        public abstract string FilePath { get; set; }
                
        public AbstractHandler(string filepath)
        {
            FilePath = filepath;
        }

        public abstract void Open();
        
        public abstract void Create();
       
        public abstract void Change();
        
        public abstract void Save();

        

    }
}
