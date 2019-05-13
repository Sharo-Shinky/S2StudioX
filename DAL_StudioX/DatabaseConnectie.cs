using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_StudioX
{
    public class DatabaseConnectie
    {
        public SqlConnection connection = new SqlConnection(connectionString);
        private const string connectionString =
            @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\StudioX\DAL_StudioX\StudioDatabase.mdf;Integrated Security = True";
        
    }
}
