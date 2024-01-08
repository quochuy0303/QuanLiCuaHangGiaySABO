using DevExpress.LookAndFeel;
using DevExpress.Skins;
using DevExpress.UserSkins;
using QuanLiCuaHangGiaySABO.QlSG;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace QuanLiCuaHangGiaySABO
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            frmLogin loginForm = new frmLogin(null); // Truyền null hoặc tham số tùy thuộc vào cách bạn sử dụng MainForm
            Application.Run(loginForm);
        }
    }
}
