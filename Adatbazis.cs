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
        public List<Dolgozo> selectDolgozo() //Adatok lekérése az adatbázisból
        {
            List<Dolgozo> dolgozok = new List<Dolgozo>(); //a lekért adatokat ide mentjuk dolgozókként

            //ez a select utasítás
            command.CommandText = "SELECT dolgozoid, dolgozonev, szuletesi_ido, neme FROM dolgozo";
            nyit();

            using (MySqlDataReader reader = command.ExecuteReader()) //Ez olvassa be és fordítja le az adatbázisból kapott infókat
            {
                while (reader.Read()) //alább a lefordítás
                {
                    ulong id = Convert.ToUInt64(reader["dolgozoid"]);
                    string nev = reader["dolgozonev"].ToString();
                    DateTime szuletes = Convert.ToDateTime(reader["szuletesi_ido"]);
                    string nem = reader["neme"].ToString();

                    Dolgozo dolgozo = new Dolgozo(id, nev, szuletes, nem);
                    dolgozok.Add(dolgozo); //mentem a fenti listában
                }
            }
            zar();
            return dolgozok;
        }
        public void updateDolgozo(Dolgozo dolgozo)
        {
            command.CommandText = "UPDATE dolgozo SET dolgozonev = @nev, szuletesi_ido = @szuletes, neme = @nem WHERE dolgozoid = @id";
            command.Parameters.Clear();
            command.Parameters.AddWithValue("@nev",dolgozo.nev);
            command.Parameters.AddWithValue("@szuletes",dolgozo.szuletes);
            command.Parameters.AddWithValue("@nem",dolgozo.nem);
            command.Parameters.AddWithValue("@id",dolgozo.id);

            nyit();
            command.ExecuteNonQuery();
            zar();
        }
    }
}
