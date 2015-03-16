using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Samaritan.UI;

namespace Samaritan.Windows
{
    public partial class MainWindows : Form
    {
        Samaritan.Property.Teams teams = new Property.Teams();
        public MainWindows()
        {
            InitializeComponent();

            menuStrip1.Renderer = new MenuStripLightTheme();
            toolStrip1.Renderer = new MenuStripLightTheme();
            contextMenuStrip1.Renderer = new MenuStripLightTheme();
            toolStripStatusLabel1.Text = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString();

            propertyGrid1.SelectedObject = teams;
        }



        private void getSourceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void propertyGrid1_Click(object sender, EventArgs e)
        {

        }
    }
}
