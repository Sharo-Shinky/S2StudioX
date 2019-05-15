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
        DatabaseConnectie DbConn = new DatabaseConnectie();

        public void AddAfspraak(AfspraakStruct afspraakStruct)
        {
            using (DbConn.connection)
            {
                string query = "INSERT INTO Afspraak (BeginTijd, EindTijd, Opmerking, KlantId, StudioId) Values" +
                               "(BeginTijd, EindTijd, Opmerking, KlantId, StudioId)";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
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
            using (DbConn.connection)
            {
                string query = "SELECT * FROM Afspraak";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
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
            using (DbConn.connection)
            {
                string query = "DELETE FROM Afspraak WHERE Id = @Id";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                SqlParameter param = new SqlParameter("@Id", id);
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateAfspraak(AfspraakStruct afspraakStruct)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Afspraak SET BeginTijd = @BeginTijd, EindTijd = @EindTijd, Opmerking = @Opmerking";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);

                command.Parameters.Add(new SqlParameter("@BeginTijd", afspraakStruct.BeginTijd));
                command.Parameters.Add(new SqlParameter("@EindTijd", afspraakStruct.EindTijd));
                command.Parameters.Add(new SqlParameter("@Opmerking", afspraakStruct.Opmerking));

                command.ExecuteNonQuery();
            }
        }
    }
}
