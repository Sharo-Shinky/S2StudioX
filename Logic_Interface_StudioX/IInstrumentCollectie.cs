﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IInstrumentCollectie
    {
        void AddInstrument(IInstrument instrument);

        void RemoveInstrument(int id);

        List<IInstrument> GetAllInstrumenten();
    }
}
