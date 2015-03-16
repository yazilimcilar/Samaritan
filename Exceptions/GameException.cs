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

namespace Samaritan.Exceptions
{
    class GameException : Exception
    {
        public GameException(string exception) : base(exception)
        {

        }
    }
}
