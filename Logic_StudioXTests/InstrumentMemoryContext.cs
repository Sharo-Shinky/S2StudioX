using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;

namespace Logic_StudioXTests
{
    public class InstrumentMemoryContext : IInstrumentContext
    {
        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            throw new NotImplementedException();
        }

        public List<InstrumentStruct> GetAllInstrumenten()
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
