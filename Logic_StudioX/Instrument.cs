using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public class Instrument
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }

        private IInstrumentDAL InstrumentDAL = Factory.CreateInstrumentDAL();

        public Instrument(InstrumentStruct instrumentStruct)
        {
            Id = instrumentStruct.Id;
            Naam = instrumentStruct.Naam;
        }

        public void UpdateInstrument(string naam = "")
        {
            if (naam != "")
            {
                Naam = naam;
            }
        }
    }
}
