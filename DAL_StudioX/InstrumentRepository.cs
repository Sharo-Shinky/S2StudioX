using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class InstrumentRepository : IInstrumentRepository, IInstrumentCollectieRepository
    {
        private IInstrumentContext InstrumentContext;

        public InstrumentRepository(IInstrumentContext instrumentContext)
        {
            InstrumentContext = instrumentContext;
        }

        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            InstrumentContext.AddInstrument(instrumentStruct);
        }

        public List<InstrumentStruct> GetAllInstrumenten()
        {
            List<InstrumentStruct> instrumentStructList = new List<InstrumentStruct>();
            foreach (InstrumentStruct instrumentStruct in InstrumentContext.GetAllInstrumenten())
            {
                instrumentStructList.Add(instrumentStruct);
            }

            return instrumentStructList;
        }

        public void RemoveInstrument(int id)
        {
            InstrumentContext.RemoveInstrument(id);
        }

        public void UpdateInstrument(InstrumentStruct instrumentStruct)
        {
            InstrumentContext.UpdateInstrument(instrumentStruct);
        }
    }
}
