using System;


namespace Exercise_3
{
    class Player : IRecodable, IPlayable
    {
        void IRecodable.Pause()
        {
            Console.WriteLine("Запись поставлена на паузу");
        }

        void IPlayable.Pause()
        {
            Console.WriteLine("Проирывание поставлено на паузу");
        }

        void IPlayable.Play()
        {
            Console.WriteLine("Проирывание начато");
        }

        void IRecodable.Record()
        {
            Console.WriteLine("Запись начата");
        }

        void IRecodable.Stop()
        {
            Console.WriteLine("Запись остановлена");
        }

        void IPlayable.Stop()
        {
            Console.WriteLine("Проирывание остановлено");
        }
    }
}
