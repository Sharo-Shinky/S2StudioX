using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IAfspraakCollectieRepository
    {
        void AddAfspraak(AfspraakStruct afspraakStruct);
        void RemoveAfspraak(int id);
        List<AfspraakStruct> GetAllAfspraken();
    }
}
