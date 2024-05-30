using ShipmentTracking.GUI;
using System;
using System.IO;
using System.Windows.Forms;

namespace ShipmentTracking
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
