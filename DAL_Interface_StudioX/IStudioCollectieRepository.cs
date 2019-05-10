using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IStudioCollectieRepository
    {
        void Add(StudioStruct studioStruct);
        void Remove(int id);
        List<StudioStruct> GetAll();
    }
}
