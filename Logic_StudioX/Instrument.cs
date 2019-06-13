using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;
using Logic_Interface_StudioX;

namespace Logic_StudioX
{
    public class Instrument : IInstrument
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public int StudioId { get; private set; }

        private IInstrumentRepository InstrumentRepository;

        public Instrument(IInstrumentRepository instrumentRepository)
        {
            InstrumentRepository = instrumentRepository;
        }

        public Instrument(InstrumentStruct instrumentStruct)
        {
            Id = instrumentStruct.Id;
            Naam = instrumentStruct.Naam;
            StudioId = instrumentStruct.StudioId;
        }

        public void UpdateInstrument(IInstrument instrument)
        {
            InstrumentRepository.UpdateInstrument(new InstrumentStruct(instrument.Id, instrument.Naam,
                                                                       instrument.StudioId));
        }
    }
}
