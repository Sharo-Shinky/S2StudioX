using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IAfspraakCollectie
    {
        void MaakAfspraak(IKlant klant, IAfspraak afspraak, IInstrument instrument1 = null, IInstrument instrument2 = null);

        void RemoveAfspraak(int id);

        List<IAfspraak> GetAllAfspraken();
    }
}
