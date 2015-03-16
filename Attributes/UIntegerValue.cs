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

namespace Samaritan.Attributes
{
    class UIntegerValue : Attribute
    {
        private uint uintValue;
        public UIntegerValue(uint value)
        {
            uintValue = value;
        }

        public uint Value
        {
            get { return uintValue; }
        }
    }
}
