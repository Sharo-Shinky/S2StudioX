using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IKlantCollectieRepository
    {
        void Add(KlantStruct klantStruct);
        void Remove(int id);
        List<KlantStruct> GetAll();
    }
}
