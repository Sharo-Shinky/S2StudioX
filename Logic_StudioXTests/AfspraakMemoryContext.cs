using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;

namespace Logic_StudioXTests
{
    public class AfspraakMemoryContext : IAfspraakContext
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
