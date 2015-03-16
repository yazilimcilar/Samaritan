//
//
// (c) 2015 Samaritan Pawn IDE - Source Code
//
//
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Samaritan.Property
{
    class Teams
    {
        private string teamName;
        private string teamMacroName;
        private SpawnWorldInfo worldInfo = new SpawnWorldInfo();
        private WeaponSet weaponSet = new WeaponSet();
        private Coordinates spawnCoordinates = new Coordinates();
        private Color teamColor;

        [Browsable(true)]
        [Category("General")]
        [Description("Team macro")]
        [DisplayName("Macro")]
        public string Macro
        {
            get { return teamMacroName; }
            set { teamMacroName = value; }
        }

        [Browsable(true)]
        [Category("General")]
        [Description("Team Name")]
        [DisplayName("Name")]
        public string Name
        {
            get { return teamName; }
            set { teamName = value; }
        }

        [Browsable(true)]
        [Category("General")]
        [Description("Team weapons")]
        [DisplayName("Weapons")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public WeaponSet WeaponSet
        {
            get { return weaponSet; }
            set { weaponSet = value; }
        }

        [Browsable(true)]
        [Category("General")]
        [Description("Team spawn coordinates")]
        [DisplayName("Coordinates")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public Coordinates Coordinate
        {
            get { return spawnCoordinates; }
            set { spawnCoordinates = value; }
        }

        [Browsable(true)]
        [Category("General")]
        [Description("Team spawn world")]
        [DisplayName("World")]
        [TypeConverter(typeof(ExpandableObjectConverter))]
        public SpawnWorldInfo World
        {
            get { return worldInfo; }
            set { worldInfo = value; }
        }

        [Browsable(true)]
        [Category("General")]
        [Description("Team color")]
        [DisplayName("Color")]
        public Color Color
        {
            get { return teamColor; }
            set { teamColor = value; }
        }
    }
}
