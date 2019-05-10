using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IInstrumentCollectieRepository
    {
        void AddInstrument(InstrumentStruct instrumentStruct);
        void RemoveInstrument(int id);
        List<InstrumentStruct> GetAllInstrument();
    }
}
