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
    [AttributeUsage(AttributeTargets.Field, AllowMultiple = false)]
    class StringValue : Attribute
    {
        private string stringVal;
        public StringValue(string value)
        {
            stringVal = value;
        }

        public string Value
        {
            get { return stringVal; }
        }
    }
}
