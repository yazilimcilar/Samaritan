//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using Samaritan.Exceptions;
using Samaritan.IO;

namespace Samaritan.Game
{
    class GameStartupArgs
    {
        private string serverIp;
        private string serverPass;
        private int serverPort;

        public GameStartupArgs(CFGReader reader)
        {
            reader.Read();
        }

        public GameStartupArgs()
        {

        }

        public string Server
        {
            get { return serverIp; }
            set
            {
                if (value.Length > 0 || value != null)
                {
                    serverIp = value;
                }
                else throw new GameException("e");
            }
        }

        public string Password
        {
            get { return serverPass; }
            set
            {
                serverPass = value;
            }
        }
    }
}
