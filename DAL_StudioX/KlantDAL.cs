using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public enum Gender
    {
        // LET OP, deze enum wordt ook gebruikt in de logic laag.
        // Belangrijk dat de volgorde van de set het zelfde blijft in elke laag.
        // Dit omdat er gecast wordt
        Onbekend,
        Man,
        Vrouw
    }
    public class KlantDAL : IKlantDAL, IKlantCollectieDAL
    {
        private SqlConnection connection;
        private const string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\StudioX\DAL_StudioX\StudioDatabase.mdf;Integrated Security = True";

        private SqlConnection GetConnection()
        {
            return connection = new SqlConnection(connectionString);
        }
        public void Add(KlantStruct klantStruct)
        {
            using (GetConnection())
            {
                //StudioId toevoegen
                string query = "INSERT INTO Klant(Voornaam, Achternaam, Geslacht, Geboortedatum, Telefoonnummer, Email," +
                               "Straat, Huisnummer, Postcode, Woonplaats, Gebruikersnaam, Wachtwoord) Values" +
                               "(@Voornaam, @Achternaam, @Geslacht, @Geboortedatum, @Telefoonnummer, @Email, @Straat," +
                               "@Huisnummer, @Postcode, @Woonplaats, @Gebruikersnaam, @Wachtwoord)";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Voornaam", klantStruct.VoorNaam);
                command.Parameters.AddWithValue("@Achternaam", klantStruct.AchterNaam);
                command.Parameters.AddWithValue("Geslacht", (int)(klantStruct.Geslacht));
                command.Parameters.AddWithValue("@Geboortedatum", klantStruct.GeboorteDatum);
                command.Parameters.AddWithValue("@Telefoonnummer", klantStruct.TelefoonNummer);
                command.Parameters.AddWithValue("Email", klantStruct.EmailAdres);
                command.Parameters.AddWithValue("Straat", klantStruct.Straat);
                command.Parameters.AddWithValue("Huisnummer", klantStruct.HuisNummer);
                command.Parameters.AddWithValue("Postcode", klantStruct.PostCode);
                command.Parameters.AddWithValue("Woonplaats", klantStruct.WoonPlaats);
                command.Parameters.AddWithValue("Gebruikersnaam", klantStruct.Gebruikersnaam);
                command.Parameters.AddWithValue("Wachtwoord", klantStruct.Wachtwoord);

                command.ExecuteNonQuery();
            }
        }

        public List<KlantStruct> GetAll()
        {
            List<KlantStruct> klantStructList = new List<KlantStruct>();
            using (GetConnection())
            {
                string query = "SELECT * FROM Klant";
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        //StudioId toevoegen
                        klantStructList.Add(new KlantStruct(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                            reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5),
                                                            reader.GetString(6), reader.GetString(7), reader.GetInt32(8),
                                                            reader.GetString(9), reader.GetString(10), reader.GetString(11),
                                                            reader.GetString(12)));
                    }
                }
            }

            return klantStructList;
        }

        public void Remove(int id)
        {
            string query = "DELETE FROM Klant WHERE Klant.Id = " + id;
            using (GetConnection())
            {
                connection.Open();
                SqlCommand command = new SqlCommand(query, connection);
                command.ExecuteNonQuery();
            }
        }

        public void Update(KlantStruct klantStruct)
        {
            throw new NotImplementedException();
        }
    }
}
