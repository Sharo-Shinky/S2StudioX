using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IAfspraak
    {
        int Id { get; }
        DateTime BeginTijd { get; }
        DateTime EindTijd { get; }
        string Opmerking { get; }
        int KlantId { get; }
        int StudioId { get; }

        void UpdateAfspraak(IAfspraak afspraak);
    }
}
