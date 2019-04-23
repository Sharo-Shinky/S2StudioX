using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public struct AfspraakStruct
    {
        public int Id { get; private set; }
        public DateTime BeginTijd { get; private set; }
        public DateTime EindTijd { get; private set; }
        public string Opmerking { get; private set; }

        public AfspraakStruct(DateTime beginTijd, DateTime eindTijd, string opmerking, int id = 0)
        {
            Id = id;
            BeginTijd = beginTijd;
            EindTijd = eindTijd;
            Opmerking = opmerking;
        }
    }
}
