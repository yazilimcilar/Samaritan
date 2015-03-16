//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samaritan.Property
{
    class SpawnWorldInfo
    {
        private int spawnVirtualWorld;
        private int spawnInterior;

        public SpawnWorldInfo()
        {
            VirtualWorld = 0;
            Interior = 0;
        }

        [DisplayName("Virtual World")]
        public int VirtualWorld
        {
            get { return spawnVirtualWorld; }
            set { spawnVirtualWorld = value; }
        }

        [DisplayName("Interior")]
        public int Interior
        {
            get { return spawnInterior; }
            set { spawnInterior = value; }
        }

        public override string ToString()
        {
            return VirtualWorld + ";" + Interior;
        }
    }
}
