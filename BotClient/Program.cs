using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace BotClient
{
    class Program
    {
        static void Main(string[] args)
        {
            faui2k15sharp.Bot Bot = new faui2k15sharp.Bot("irc.fau.de");
            Console.ReadKey();
        }
    }
}
