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
    class WeaponInfo
    {
        private int weaponId;
        private int weaponAmmo;

        public WeaponInfo()
        {
            Weapon = 0;
            Ammo = 0;
        }

        [DisplayName("Weapon")]
        public int Weapon
        {
            get { return weaponId; }
            set { weaponId = value; }
        }

        [DisplayName("Ammo")]
        public int Ammo
        {
            get { return weaponAmmo; }
            set { weaponAmmo = value; }
        }

        public override string ToString()
        {
            return Weapon + ";" + Ammo;
        }
    }
}
