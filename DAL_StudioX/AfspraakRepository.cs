using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class AfspraakRepository : IAfspraakRepository, IAfspraakCollectieRepository
    {
        private IAfspraakContext AfspraakContext;

        public AfspraakRepository(IAfspraakContext afspraakContext)
        {
            AfspraakContext = afspraakContext;
        }

        public void AddAfspraak(AfspraakStruct afspraakStruct)
        {
            AfspraakContext.AddAfspraak(afspraakStruct);
        }

        public List<AfspraakStruct> GetAllAfspraken()
        {
            List<AfspraakStruct> afspraakStructList = new List<AfspraakStruct>();
            foreach (AfspraakStruct afspraakStruct in AfspraakContext.GetAllAfspraken())
            {
                afspraakStructList.Add(afspraakStruct);
            }

            return afspraakStructList;
        }

        public void RemoveAfspraak(int id)
        {
            AfspraakContext.RemoveAfspraak(id);
        }

        public void UpdateAfspraak(AfspraakStruct afspraakStruct)
        {
            AfspraakContext.UpdateAfspraak(afspraakStruct);
        }
    }
}
