using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sistema_Gimnasio
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            bool flag = true;
            while (flag)
            {
                using (var login = new LoginView())
                {
                    if (login.ShowDialog() == DialogResult.OK)
                    {
                        var user = login.UserAuth;
                        Application.Run(new Form1(user));
                    }
                    else
                    {
                        flag = false;
                    }

                }


            }
        }
    }
}
