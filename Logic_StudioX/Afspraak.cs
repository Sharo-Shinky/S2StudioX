using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public class Afspraak
    {
        public int Id { get; private set; }
        public DateTime BeginTijd { get; private set; }
        public DateTime EindTijd { get; private set; }
        public string Opmerking { get; private set; }

        public List<Instrument> Instrumenten = new List<Instrument>();

        private IAfspraakDAL AfspraakDAL = Factory.CreateAfspraakDAL();

        public Afspraak(AfspraakStruct afspraakStruct)
        {
            Id = afspraakStruct.Id;
            BeginTijd = afspraakStruct.BeginTijd;
            EindTijd = afspraakStruct.EindTijd;
            Opmerking = afspraakStruct.Opmerking;
        }

        public void UpdateAfspraak(DateTime beginTijd, DateTime eindTijd, string opmerking)
        {
            if (beginTijd != BeginTijd)
            {
                BeginTijd = beginTijd;
            }

            if (eindTijd != EindTijd)
            {
                EindTijd = eindTijd;
            }

            if (opmerking != "")
            {
                Opmerking = opmerking;
            }
        }
    }
}
