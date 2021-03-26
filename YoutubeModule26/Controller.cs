using System;
using System.Collections.Generic;
using System.Text;

namespace YoutubeModule26
{
    class Controller
    {
        IAction _action;
        public void SetAction(IAction action)
        {
            _action = action;
        }

        public void Execute()
        {
            _action.Run();
        }
    }
}
