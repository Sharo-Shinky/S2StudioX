using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public interface IAfspraakContext
    {
        void AddAfspraak(AfspraakStruct afspraakStruct);

        void RemoveAfspraak(int id);

        List<AfspraakStruct> GetAllAfspraken();

        void UpdateAfspraak(AfspraakStruct afspraakStruct);
    }
}
