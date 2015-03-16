//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samaritan.Interface
{
    class INetworkConnection
    {
        void Connect();
        void Disconnect();

        string server;
        string password;
        string user;
    }
}
