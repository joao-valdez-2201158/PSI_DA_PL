using System;
using System.Windows.Forms;

namespace Projeto_DA_BooKids
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new BooKids_Form());
        }
    }
}
