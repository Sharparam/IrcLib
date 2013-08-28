using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sharparam.IrcLib
{
    public class IrcClient
    {
        public string Server { get; private set; }
        public short Port { get; private set; }

        public IrcClient(string server, short port)
        {
            
        }
    }
}
