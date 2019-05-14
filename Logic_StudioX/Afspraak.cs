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
        public int KlantId { get; private set; }
        public int StudioId { get; private set; }

        private IAfspraakRepository AfspraakRepository = Factory.CreateAfspraakSQLContext();

        public Afspraak(AfspraakStruct afspraakStruct)
        {
            Id = afspraakStruct.Id;
            BeginTijd = afspraakStruct.BeginTijd;
            EindTijd = afspraakStruct.EindTijd;
            Opmerking = afspraakStruct.Opmerking;
            KlantId = afspraakStruct.KlantId;
            StudioId = afspraakStruct.StudioId;
        }

        public void UpdateAfspraak(AfspraakStruct afspraakStruct)
        {
            AfspraakRepository.UpdateAfspraak(afspraakStruct);
        }
    }
}
