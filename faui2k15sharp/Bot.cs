using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace faui2k15sharp
{
    public class Bot
    {
        public Bot(string ServerAddress)
        {
            BotInstance = new faui2k15sharp(ServerAddress);
        }
        private faui2k15sharp _BotInstance;
        private faui2k15sharp BotInstance
        {
            get
            {
                if(_BotInstance.IsConnected)
                {
                    return _BotInstance;
                }
                else
                {
                    throw new Exception("Bot not connected");
                }
            }
            set
            {
                if(_BotInstance == null && value != null)
                {
                    _BotInstance = value;
                    _BotInstance.Connect();
                }
                else
                {
                    throw new Exception("BotInstance already exists.");
                }
            }
        }

        public bool IsConnected
        {
            get { return _BotInstance.IsConnected; }
        }

        ~Bot()
        {
            if (IsConnected)
            {
                BotInstance.Disconnect();
            }
        }
    }
}
