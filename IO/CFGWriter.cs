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

using Samaritan.Exceptions;

namespace Samaritan.IO
{
    class CFGWriter
    {
        public Dictionary<CFGKey, string> Key { private set; get; }
        public string Path { get; set; }

        public void Write(CFGKey key, string value)
        {

        }
    }
}
