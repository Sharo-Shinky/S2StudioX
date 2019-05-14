using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public interface IInstrumentContext
    {
        void AddInstrument(InstrumentStruct instrumentStruct);

        void RemoveInstrument(int id);

        List<InstrumentStruct> GetAllInstrumenten();

        void UpdateInstrument(InstrumentStruct instrumentStruct);
    }
}
