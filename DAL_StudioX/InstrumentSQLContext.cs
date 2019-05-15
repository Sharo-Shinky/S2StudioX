using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class InstrumentSQLContext : IInstrumentContext
    {
        DatabaseConnectie DbConn = new DatabaseConnectie();
        
        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            using (DbConn.connection)
            {
                string query = "INSERT INTO Instrument (Naam, StudioId, AfspraakId) Values (@Naam, @StudioId, @AfspraakId)";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.AddWithValue("@Naam", instrumentStruct.Naam);
                command.Parameters.AddWithValue("@StudioId", instrumentStruct.StudioId);
                command.Parameters.AddWithValue("@AfspraakId", instrumentStruct.AfspraakId);

                command.ExecuteNonQuery();
            }
        }

        public List<InstrumentStruct> GetAllInstrumenten()
        {
            List<InstrumentStruct> instrumentStructList = new List<InstrumentStruct>();
            using (DbConn.connection)
            {
                string query = "SELECT * FROM Instrument";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        instrumentStructList.Add(new InstrumentStruct(reader.GetInt32(0), reader.GetString(1),
                                                                      reader.GetInt32(2), reader.GetInt32(3)));
                    }
                }
            }

            return instrumentStructList;
        }

        public void RemoveInstrument(int id)
        {
            using (DbConn.connection)
            {
                string query = "DELETE FROM Instrument WHERE Id = @Id";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                SqlParameter param = new SqlParameter("Id", id);
                command.Parameters.Add(param);
                command.ExecuteNonQuery();
            }
        }

        public void UpdateInstrument(InstrumentStruct instrumentStruct)
        {
            using (DbConn.connection)
            {
                string query = "UPDATE Instrument SET Naam = @Naam";
                DbConn.connection.Open();
                SqlCommand command = new SqlCommand(query, DbConn.connection);
                command.Parameters.Add(new SqlParameter("@Naam", instrumentStruct.Naam));
                command.ExecuteNonQuery();
            }
        }
    }
}