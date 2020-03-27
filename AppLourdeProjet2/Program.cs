using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppLourdeProjet2
{
    static class Program
    {
        public static DB mybdd;
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            mybdd = new DB("192.168.2.4", "bdolaporte2", "sqlolaporte", "savary");

            //ouvre la connexion
            if (Program.mybdd.OpenConnection() != true)
                Application.Exit();

                      
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());

            //ferme la connexion
            Program.mybdd.CloseConnection();
        }
    }
}
