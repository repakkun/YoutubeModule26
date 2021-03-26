using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;
using YoutubeExplode.Converter;
using YoutubeExplode.Videos;

namespace YoutubeModule26
{
    public class Reciever
    {
        string OutputFilePath = Console.ReadLine();
        string link = Console.ReadLine();
        YoutubeClient client = new YoutubeClient();
   
        public async void Information()
        {
            Console.WriteLine("Выводим инфу о видео");
            var video = await client.Videos.GetAsync(link);
            var title = video.Title;
            var author = video.Author;
            var desc = video.Description;
            Console.WriteLine(title, " ", author, " ", desc);
        }      
        public async void Download()
        {
           Console.WriteLine("Скачиваем");
           await client.Videos.DownloadAsync(link, OutputFilePath);
        }
    }
}
