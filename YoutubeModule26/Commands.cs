using System;
using System.Collections.Generic;
using System.Text;
using YoutubeExplode;

namespace YoutubeModule26
{
    public class Commands : IAction
    {      
        Reciever _reciever;
        public Commands(Reciever reciever)
        {
            _reciever = reciever;
        }
        public void Run()
        {
            _reciever.Information();
            _reciever.Download();
        }      
    }
}
