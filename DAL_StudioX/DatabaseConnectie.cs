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
        public SqlConnection connection
        {
            get { return new SqlConnection(connectionString); }
        }

        private const string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\249519\source\repos\Sharo-Shinky\KillerAppS2\StudioX\DAL_StudioX\StudioDB.mdf;Integrated Security=True";

        private const string connstring = "Server=mssql.fhict.local;Database=dbi249519;User Id=dbi249519;Password=Dilkash1964";
    }
}
