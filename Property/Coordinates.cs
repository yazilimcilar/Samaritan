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

namespace Samaritan.Property
{
    class Coordinates
    { 
        public string X { get; set; }
        public string Y { get; set; }
        public string Z { get; set; }
        public string Angle { get; set; }

        public Coordinates()
        {
            X = "0, 0";
            Y = "0, 0";
            Z = "0, 0";
            Angle = "0, 0";
        }

        public override string ToString()
        {
            return X + ";" + Y + ";" + Z + ";" + Angle;
        }
    }
}
