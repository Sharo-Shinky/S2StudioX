using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public struct InstrumentStruct
    {
        public int Id { get; private set; }
        public string Naam { get; }

        public InstrumentStruct(string naam, int id = 0)
        {
            Id = id;
            Naam = naam;
        }
    }
}
