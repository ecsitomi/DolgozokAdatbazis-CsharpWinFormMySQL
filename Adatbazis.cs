using System;
using System.Collections.Generic;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Input;
using MySql.Data.MySqlClient;

namespace loginForm
{
    internal class Adatbazis
    {
        MySqlCommand command = null;
        MySqlConnection connection = null;

        public Adatbazis()
        {
            MySqlConnectionStringBuilder builder = new MySqlConnectionStringBuilder();
            builder.Server = "localhost";
            builder.UserID = "root";
            builder.Password = "";
            builder.Database = "dolgozo";
            builder.CharacterSet = "utf8";
            connection = new MySqlConnection(builder.ConnectionString);
            try
            {
                nyit();
                command = connection.CreateCommand();
                zar();
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message);
                Environment.Exit(0);
            }
            
        }

        private void zar()
        {
            if (connection.State != System.Data.ConnectionState.Closed)
            {
                connection.Close();
            }
        }

        private void nyit()
        {
            if (connection.State!=System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public void instertDolgozo(string nev, DateTime szuletes, string nem)
        {
            command.CommandText = "INSERT INTO `dolgozo` (`dolgozoid`,`dolgozonev`,`szuletesi_ido`,`neme`) VALUES (NULL, @nev, @szuletes, @nem)";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev", nev);
            command.Parameters.AddWithValue("@szuletes", szuletes.ToString("yyyy-MM-dd"));
            command.Parameters.AddWithValue("@nem", nem);
            nyit();
            command.ExecuteNonQuery();
            zar();

        }
    }
}
