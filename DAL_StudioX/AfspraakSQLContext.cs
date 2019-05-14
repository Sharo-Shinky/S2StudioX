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
        public void AddAfspraak(AfspraakStruct afspraakStruct)
        {
            throw new NotImplementedException();
        }

        public List<AfspraakStruct> GetAllAfspraken()
        {
            throw new NotImplementedException();
        }

        public void RemoveAfspraak(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateAfspraak(AfspraakStruct afspraakStruct)
        {
            throw new NotImplementedException();
        }
    }
}
