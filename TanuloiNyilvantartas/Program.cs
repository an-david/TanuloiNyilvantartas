using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace TanuloiNyilvantartas
{
    static class Program
    {
        public static tagLetrehozas letrehoz = null;
        public static tagModositas modosit = null;
        public static MySqlConnection conn = null;
        public static MySqlCommand sql = null;
        public static Form_Nyito nyito = null;

        [STAThread]
        static void Main()
        {
            MySqlConnectionStringBuilder sb = new MySqlConnectionStringBuilder();
            sb.Server = "localhost";
            sb.UserID = "root";
            sb.Password = "";
            sb.Database = "tagdij";

            conn = new MySqlConnection(sb.ToString());

            try
            {
                conn.Open();
                sql = conn.CreateCommand();
            }
            catch (MySqlException ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadKey();
                Environment.Exit(0);
            }


            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            letrehoz = new tagLetrehozas();
            modosit = new tagModositas();
            nyito = new Form_Nyito();

            Application.Run(nyito);
        }
    }
}
