using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Enums;

namespace DAL_StudioX
{
    public class KlantSQLContext : IKlantContext
    {
        DatabaseConnectie DbConn = new DatabaseConnectie();
        public void Add(KlantStruct klantStruct)
        {
            using (DbConn.connection)
            {
                string query = "INSERT INTO Klant(Voornaam, Achternaam, Geslacht, Geboortedatum, Telefoonnummer, Email," +
                               "Straat, Huisnummer, Postcode, Woonplaats, Gebruikersnaam, Wachtwoord, StudioId) Values" +
                               "(@Voornaam, @Achternaam, @Geslacht, @Geboortedatum, @Telefoonnummer, @Email, @Straat," +
                               "@Huisnummer, @Postcode, @Woonplaats, @Gebruikersnaam, @Wachtwoord, @StudioId)";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
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
                command.Parameters.AddWithValue("StudioId", klantStruct.StudioId);

                command.ExecuteNonQuery();
            }
        }

        public List<KlantStruct> GetAll()
        {
            List<KlantStruct> klantStructList = new List<KlantStruct>();
            using (DbConn.connection)
            {
                string query = "SELECT * FROM Klant";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        klantStructList.Add(new KlantStruct(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                            reader.GetInt32(3), reader.GetDateTime(4), reader.GetString(5),
                                                            reader.GetString(6), reader.GetString(7), reader.GetInt32(8),
                                                            reader.GetString(9), reader.GetString(10), reader.GetString(11),
                                                            reader.GetString(12), reader.GetInt32(13)));
                    }
                }
            }

            return klantStructList;
        }

        public void Remove(int id)
        {
            using (DbConn.connection)
            {
                string query = "DELETE FROM Klant WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Id", id);
                
                command.ExecuteNonQuery();
            }
        }

        public void Update(KlantStruct klantStruct)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Klant SET Voornaaam = @Voornaam, Achternaam = @Achternaam, Geslacht = @Geslacht, " +
                               "Geboortedatum = @Geboortedatum, Telefoonnummer = @Telefoonnummer, Email = @Email, " +
                               "Straat = @Straat, Huisnummer = @Huisnummer, Postcode = @Postcode, Woonplaats = @Woonplaats" +
                               " WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Voornaam", klantStruct.VoorNaam);
                command.Parameters.AddWithValue("@Achternaam", klantStruct.AchterNaam);
                command.Parameters.AddWithValue("@Geslacht", (int)klantStruct.Geslacht);
                command.Parameters.AddWithValue("@Geboortedatum", klantStruct.GeboorteDatum);
                command.Parameters.AddWithValue("@Telefoonnummer", klantStruct.TelefoonNummer);
                command.Parameters.AddWithValue("@Straat", klantStruct.Straat);
                command.Parameters.AddWithValue("@Huisnummer", klantStruct.HuisNummer);
                command.Parameters.AddWithValue("@Postcode", klantStruct.PostCode);
                command.Parameters.AddWithValue("@Woonplaats", klantStruct.WoonPlaats);
                command.Parameters.AddWithValue("Id", klantStruct.Id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Klant SET Gebruikersnaam = @Gebruikersnaam WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            string query = "UPDATE Klant SET Wachtwoord = @Wachtwoord WHERE Id = @Id";
            DbConn.connection.Open();

            SqlCommand command = new SqlCommand(query, DbConn.connection);
            command.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
}
