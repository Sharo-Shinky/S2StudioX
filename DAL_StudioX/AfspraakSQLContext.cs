using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class AfspraakSQLContext : IAfspraakContext
    {
        private DatabaseConnectie DbConn;

        public AfspraakSQLContext()
        {
            DbConn = new DatabaseConnectie();
        }

        public void AddAfspraak(AfspraakStruct afspraakStruct)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "INSERT INTO Afspraak (BeginTijd, EindTijd, Opmerking, KlantId, StudioId) Values" +
                               "(@BeginTijd, @EindTijd, @Opmerking, @KlantId, @StudioId)";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@BeginTijd", afspraakStruct.BeginTijd);
                command.Parameters.AddWithValue("@EindTijd", afspraakStruct.EindTijd);
                command.Parameters.AddWithValue("@Opmerking", afspraakStruct.Opmerking);
                command.Parameters.AddWithValue("@KlantId", afspraakStruct.KlantId);
                command.Parameters.AddWithValue("@StudioId", afspraakStruct.StudioId);

                command.ExecuteNonQuery();
            }
        }

        public List<AfspraakStruct> GetAllAfspraken()
        {
            List<AfspraakStruct> afspraakStructList = new List<AfspraakStruct>();
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "SELECT * FROM Afspraak";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        afspraakStructList.Add(new AfspraakStruct(reader.GetInt32(0), reader.GetDateTime(1), reader.GetDateTime(2),
                                                                  reader.GetString(3), reader.GetInt32(4), reader.GetInt32(5)));
                    }
                }
            }

            return afspraakStructList;
        }

        public void RemoveAfspraak(int id)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "DELETE FROM Afspraak WHERE Id = @Id";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Id", id);

                command.ExecuteNonQuery();
            }
        }

        public void UpdateAfspraak(AfspraakStruct afspraakStruct)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "UPDATE Afspraak SET BeginTijd = @BeginTijd, EindTijd = @EindTijd, Opmerking = @Opmerking";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@BeginTijd", afspraakStruct.BeginTijd);
                command.Parameters.AddWithValue("@EindTijd", afspraakStruct.EindTijd);
                command.Parameters.AddWithValue("@Opmerking", afspraakStruct.Opmerking);
                
                command.ExecuteNonQuery();
            }
        }
    }
}
