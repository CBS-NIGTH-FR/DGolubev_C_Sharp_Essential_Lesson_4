using System;


namespace Exercise_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Выберите номер кнопки:\n1 - Проигрывание мелодии\n2 - Пауза мелодии\n3 - Остановка мелодии" +
                "\n4 - Запись трека\n5 - Пауза записи\n6 - Остановка записи");
            int i = Convert.ToInt32(Console.ReadLine());
            UsePlayer(i);
            Console.ReadKey();
        }

        public static void UsePlayer(int button) 
        {
            Player player;
            switch (button)
            {
                case 1:
                    player = new Player();
                    (player as IPlayable).Play();
                    break;
                case 2:
                    player = new Player();
                    (player as IPlayable).Pause();
                    break;
                case 3:
                    player = new Player();
                    (player as IPlayable).Stop();
                    break;
                case 4:
                    player = new Player();
                    (player as IRecodable).Record();
                    break;
                case 5:
                    player = new Player();
                    (player as IRecodable).Pause();
                    break;
                case 6:
                    player = new Player();
                    (player as IRecodable).Stop();
                    break;
            }
        }
    }
}
