using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IStudioCollectie
    {
        void Add(IStudio studio);

        void Remove(int id);

        List<IStudio> GetAll();
    }
}
