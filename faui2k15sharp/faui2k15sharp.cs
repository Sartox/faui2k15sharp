using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ChatSharp;

namespace faui2k15sharp
{
    public class faui2k15sharp
    {
        public faui2k15sharp(string serverAddress)
        {
            BotUser = new IrcUser("faui2k15#", "C#-Bot");
             BotClient = new IrcClient(serverAddress, BotUser);
             BotClient.ConnectionFailedEvent += BotClient_ConnectionFailedEvent;
             BotClient.ConnectionComplete += BotClient_ConnectionComplete;
            /*
            client.ConnectionComplete += (s, e) => client.JoinChannel("#faui2k15");

            client.ChannelMessageRecieved += (s, e) =>
            {
                var channel = client.Channels[e.PrivateMessage.Source];
                if (e.PrivateMessage.Message == ".list")
                    channel.SendMessage(string.Join(", ", channel.Users.Select(u => u.Nick)));
                else if (e.PrivateMessage.Message.StartsWith(".ban "))
                {
                    if (!channel.UsersByMode['@'].Contains(client.User))
                    {
                        channel.SendMessage("I'm not an op here!");
                        return;
                    }
                    var target = e.PrivateMessage.Message.Substring(5);
                    client.WhoIs(target, whois => channel.Kick("*!*@" + whois.User.Hostname));
                }
            };
             */
        }

        void BotClient_ConnectionFailedEvent(object sender, ChatSharp.Events.ConnectionFailedEventArgs Args)
        {
            Console.WriteLine("Connection Failed: " + Args.Exception.Message);
        }

        void BotClient_ConnectionComplete(object sender, EventArgs e)
        {
            IsConnected = true;
        }

        private IrcClient _BotClient;
        private IrcUser _BotUser;
        private bool _IsConnected;

        private IrcClient BotClient
        {
            get {  return _BotClient;}
            set { _BotClient = value; }
        }
        private IrcUser BotUser
        {
            get { return _BotUser; }
            set { _BotUser = value; }
        }
        public bool IsConnected
        {
            get { return _IsConnected; }
            private set { _IsConnected = value; }
        }
        /// <summary>
        /// Connects to ServerAddress
        /// </summary>
        public void Connect()
        {
            BotClient.ConnectAsync();
        }
        public void Disconnect(string disconnectReason = null)
        {
            BotClient.Quit(disconnectReason);
            IsConnected = false;
        }
    }
}
