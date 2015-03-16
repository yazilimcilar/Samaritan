using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samaritan.Windows
{
    public partial class SplashScreen : Form
    {
        private Point cursorPoint;
        private Point formPoint;
        private bool dragging;

        public SplashScreen()
        {
            Version productVersion = System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
            InitializeComponent();
            label1.Text = "Ver: " + productVersion.Major + "." + productVersion.Minor;
            label2.Text = "Build: " + productVersion.Build;
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            dragging = true;
            cursorPoint = Cursor.Position;
            formPoint = Location;
        }

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
            if (dragging)
            {
                Point dif = Point.Subtract(Cursor.Position, new Size(cursorPoint));
                Location = Point.Add(formPoint, new Size(dif));
            }
        }

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
            dragging = false;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hide();
            MainWindows main = new MainWindows();
            main.Show();
            timer1.Stop();
        }
    }
}
