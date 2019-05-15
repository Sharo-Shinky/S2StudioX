using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class StudioSQLContext : IStudioContext
    {
        DatabaseConnectie DbConn = new DatabaseConnectie();

        public void Add(StudioStruct studioStruct)
        {
            using (DbConn.connection)
            {
                string query = "INSERT INTO Studio(Naam, Straat, Huisnummer, Postcode, Woonplaats, Email," +
                               "Telefoonnummer, Gebruikersnaam, Wachtwoord) Values (@Naam, @Straat, @Huisnummer" +
                               "@Postcode, @Woonplaats, @Email, @Telefoonnummer, @Gebruikersnaam, @Wachtwoord)";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Naam", studioStruct.Naam);
                command.Parameters.AddWithValue("@Straat", studioStruct.Straat);
                command.Parameters.AddWithValue("@Huisnummer", studioStruct.HuisNummer);
                command.Parameters.AddWithValue("@Postcode", studioStruct.PostCode);
                command.Parameters.AddWithValue("@Woonplaats", studioStruct.WoonPlaats);
                command.Parameters.AddWithValue("@Email", studioStruct.EmailAdres);
                command.Parameters.AddWithValue("@Telefoonnummer", studioStruct.TelefoonNummer);
                command.Parameters.AddWithValue("@Gebruikersnaam", studioStruct.Gebruikersnaam);
                command.Parameters.AddWithValue("@Wachtwoord", studioStruct.Wachtwoord);

                command.ExecuteNonQuery();
            }
        }

        public List<StudioStruct> GetAll()
        {
            List<StudioStruct> studioStructList = new List<StudioStruct>();
            using (DbConn.connection)
            {
                string query = "SELECT * FROM Studio";
                DbConn.connection.Open();

                SqlCommand command  = new SqlCommand(query, DbConn.connection);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        studioStructList.Add(new StudioStruct(reader.GetInt32(0), reader.GetString(1), reader.GetString(2),
                                                              reader.GetInt32(3), reader.GetString(4), reader.GetString(5),
                                                              reader.GetString(6), reader.GetString(7), reader.GetString(8),
                                                              reader.GetString(9)));
                    }
                }
            }

            return studioStructList;
        }

        public void Remove(int id)
        {
            using (DbConn.connection)
            {
                string query = "DELETE FROM Studio WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public void Update(StudioStruct studioStruct)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Studio SET Naam = @Naam, Straat = @Straat, Huisnummer = @Huisnummer," +
                               "Postcode = @Postcode, Woonplaats = @Woonplaats, Email = @Email," +
                               "Telefoonnummer = @Telefoonnummer, WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Naam", studioStruct.Naam);
                command.Parameters.AddWithValue("@Straat", studioStruct.Straat);
                command.Parameters.AddWithValue("@Huisnummer", studioStruct.HuisNummer);
                command.Parameters.AddWithValue("@Postcode", studioStruct.PostCode);
                command.Parameters.AddWithValue("@Woonplaats", studioStruct.WoonPlaats);
                command.Parameters.AddWithValue("@Email", studioStruct.EmailAdres);
                command.Parameters.AddWithValue("@Telefoonnummer", studioStruct.TelefoonNummer);
                command.Parameters.AddWithValue("Id", studioStruct.Id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Studio SET Gebruikersnaam = @Gebruikersnaam WHERE Id = @Id";
                DbConn.connection.Open();

                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Gebruikersnaam", gebruikersnaam);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            string query = "UPDATE Studio SET Wachtwoord = @Wachtwoord WHERE Id = @Id";
            DbConn.connection.Open();

            SqlCommand command = new SqlCommand(query, DbConn.connection);
            command.Parameters.AddWithValue("@Wachtwoord", wachtwoord);
            command.Parameters.AddWithValue("@Id", id);

            command.ExecuteNonQuery();
        }
    }
}
