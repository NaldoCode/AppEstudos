using System;
using System.Windows.Forms;

namespace AppEstudos
{
    static class Program
    {
        /// <summary>
        /// Naldo Santos
        /// https://www.youtube.com/channel/UCrc8mZHlz-XiGOxqzSJjusQ
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
