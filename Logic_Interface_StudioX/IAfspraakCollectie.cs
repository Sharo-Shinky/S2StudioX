using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IAfspraakCollectie
    {
        void AddAfspraak(IAfspraak afspraak);

        void RemoveAfspraak(int id);

        List<IAfspraak> GetAllAfspraken();
    }
}
