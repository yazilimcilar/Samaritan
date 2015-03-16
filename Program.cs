using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Samaritan
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            if (args.Length != 0)
            {
                MessageBox.Show(args[0]);
                if (Path.GetExtension(args[0]).Contains("pwn") || Path.GetExtension(args[0]).Contains("inc"))
                {
                    MessageBox.Show("It's script file");
                }
                else if (Path.GetExtension(args[0]).Contains("smrtn"))
                {
                    MessageBox.Show("It's project file");
                }
                else
                {
                    MessageBox.Show("File extension not supported!", "Samaritan", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                Application.Run(new Windows.MainWindows());
            }
        }

        static void Associate()
        {

        }

       
    }
}
