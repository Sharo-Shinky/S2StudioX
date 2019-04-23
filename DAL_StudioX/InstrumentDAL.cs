using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class InstrumentDAL : IInstrumentCollectieDAL, IInstrumentDAL
    {
        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            throw new NotImplementedException();
        }

        public List<InstrumentStruct> GetAllInstrument()
        {
            throw new NotImplementedException();
        }

        public void RemoveInstrument(int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateInstrument(InstrumentStruct instrumentStruct)
        {
            throw new NotImplementedException();
        }
    }
}
