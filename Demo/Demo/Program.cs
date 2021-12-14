using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Demo
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
            //Application.Run(new splash_screen());
            //Application.Run(new KetNoiCSDL());
            //Application.Run(new fUser());
            //////Application.Run(new fThongBao_YSO());
            //Application.Run(new fMainSales());
            //Application.Run(new fLoadCTPN());
            //Application.Run(new fMain());
            //Application.Run(new fLoadChiTietHD());
            Application.Run(new GUI_Login());
        }
    }
}
