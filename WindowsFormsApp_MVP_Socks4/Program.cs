using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp_MVP_Socks4.Control;
using WindowsFormsApp_MVP_Socks4.Model;
using WindowsFormsApp_MVP_Socks4.Presenter;
using WindowsFormsApp_MVP_Socks4.View;

namespace WindowsFormsApp_MVP_Socks4
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            ApplicationController controller = new ApplicationController(new LightInjectAdapter());
            controller.RegisterModel<IModel, Model_Type>();
            controller.RegisterView<IViewType, Form1>();

            controller.Run<PresenterType>();
        }
    }
}
