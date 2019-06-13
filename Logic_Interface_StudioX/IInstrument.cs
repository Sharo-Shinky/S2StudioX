using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IInstrument
    {
        int Id { get; }
        string Naam { get; }
        int StudioId { get; }

        void UpdateInstrument(IInstrument instrument);
    }
}
