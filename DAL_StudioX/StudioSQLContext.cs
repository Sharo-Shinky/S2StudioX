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
            }
        }

        public List<StudioStruct> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }

        public void Update(StudioStruct studioStruct)
        {
            throw new NotImplementedException();
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            throw new NotImplementedException();
        }
    }
}
