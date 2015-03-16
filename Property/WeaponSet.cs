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
    class WeaponSet
    {
        private WeaponInfo firstSlot = new WeaponInfo();
        private WeaponInfo secondSlot = new WeaponInfo();
        private WeaponInfo thirdSlot = new WeaponInfo();

        public WeaponSet()
        {
            FirstSlot.Ammo = 0;
            FirstSlot.Weapon = 0;
            SecondSlot.Weapon = 0;
            SecondSlot.Ammo = 0;
            ThirdSlot.Weapon = 0;
            ThirdSlot.Ammo = 0;
        }

        [DisplayName("First Slot")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WeaponInfo FirstSlot
        {
            get { return firstSlot; }
            set { firstSlot = value; }
        }

        [DisplayName("Second Slot")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WeaponInfo SecondSlot
        {
            get { return secondSlot; }
            set { secondSlot = value; }
        }

        [DisplayName("Third Slot")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WeaponInfo ThirdSlot
        {
            get { return thirdSlot; }
            set { thirdSlot = value; }
        }

        public override string ToString()
        {
            return FirstSlot.Weapon + ", " + FirstSlot.Ammo + ";" + SecondSlot.Weapon + ", " + SecondSlot.Ammo + ";" + ThirdSlot.Weapon + "," + ThirdSlot.Ammo;
        }
    }
}
