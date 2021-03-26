using System;
using YoutubeExplode;

namespace YoutubeModule26
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите ссылку на видео и путь загрузки файла");
            Reciever reciever = new Reciever();
            Controller controller = new Controller();
            
            controller.SetAction(new Commands(reciever));
            
            controller.Execute();
        }
    }
}
