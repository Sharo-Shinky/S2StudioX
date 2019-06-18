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
        private List<InstrumentStruct> instrumentList = new List<InstrumentStruct>();

        public InstrumentMemoryContext()
        {
            instrumentList.Add(new InstrumentStruct("Fluit", 1));
            instrumentList.Add(new InstrumentStruct("Gitaar", 1));
            instrumentList.Add(new InstrumentStruct("Piano", 1));
        }

        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            instrumentList.Add(instrumentStruct);
        }

        public List<InstrumentStruct> GetAllInstrumenten()
        {
            return instrumentList;
        }

        public void RemoveInstrument(int id)
        {
            instrumentList.RemoveAt(id);
        }

        public void UpdateInstrument(InstrumentStruct instrumentStruct)
        {
            InstrumentStruct instrument = instrumentList.FirstOrDefault(instrmnt => instrmnt.Id == instrumentStruct.Id);
        }
    }
}
