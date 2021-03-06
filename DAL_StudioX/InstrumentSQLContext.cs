﻿using System;
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
        private DatabaseConnectie DbConn;

        public InstrumentSQLContext()
        {
            DbConn = new DatabaseConnectie();
        }
        
        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "INSERT INTO Instrument (Naam, StudioId) Values (@Naam, @StudioId)";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Naam", instrumentStruct.Naam);
                command.Parameters.AddWithValue("@StudioId", instrumentStruct.StudioId);

                command.ExecuteNonQuery();
            }
        }

        public List<InstrumentStruct> GetAllInstrumenten()
        {
            List<InstrumentStruct> instrumentStructList = new List<InstrumentStruct>();
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "SELECT * FROM Instrument";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);

                using (SqlDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        instrumentStructList.Add(new InstrumentStruct(reader.GetInt32(0), reader.GetString(1),
                                                                      reader.GetInt32(2)));
                    }
                }
            }

            return instrumentStructList;
        }

        public void RemoveInstrument(int id)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "DELETE FROM Instrument WHERE Id = @Id";
                conn.Open();

                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("Id", id);
                
                command.ExecuteNonQuery();
            }
        }

        public void UpdateInstrument(InstrumentStruct instrumentStruct)
        {
            using (SqlConnection conn = DbConn.connection)
            {
                string query = "UPDATE Instrument SET Naam = @Naam";
                conn.Open();
                
                SqlCommand command = new SqlCommand(query, conn);
                command.Parameters.AddWithValue("@Naam", instrumentStruct.Naam);
                
                command.ExecuteNonQuery();
            }
        }
    }
}