using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public class AfspraakStruct
    {
        public int Id { get; private set; }
        public DateTime BeginTijd { get; private set; }
        public DateTime EindTijd { get; private set; }
        public string Opmerking { get; private set; }
        public int KlantId { get; private set; }
        public int StudioId { get; private set; }

        public AfspraakStruct(int id, DateTime beginTijd, DateTime eindTijd, string opmerking, int klantId, int studioId)
        {
            Id = id;
            BeginTijd = beginTijd;
            EindTijd = eindTijd;
            Opmerking = opmerking;
            KlantId = klantId;
            StudioId = studioId;
        }
    }
}
