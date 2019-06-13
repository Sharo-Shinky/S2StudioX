using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public class InstrumentStruct
    {
        public int Id { get; private set; }
        public string Naam { get; }
        public int StudioId { get; private set; }


        public InstrumentStruct(int id, string naam, int studioId)
        {
            Id = id;
            Naam = naam;
            StudioId = studioId;
        }
        public InstrumentStruct(string naam, int studioId)
        {
            Naam = naam;
            StudioId = studioId;
        }

    }
}
