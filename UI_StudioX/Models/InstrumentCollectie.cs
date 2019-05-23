using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interface_StudioX;

namespace UI_StudioX.Models
{
    public class InstrumentCollectie
    {
        List<IInstrument> InstrumentList = new List<IInstrument>();

        public InstrumentCollectie(List<IInstrument> instrumentList)
        {
            InstrumentList = instrumentList;
        }
    }
}
