using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class StudioRepository : IStudioRepository, IStudioCollectieRepository
    {
        private IStudioContext StudioContext;

        public StudioRepository(IStudioContext studioContext)
        {
            StudioContext = studioContext;
        }

        public void Add(StudioStruct studioStruct)
        {
            StudioContext.Add(studioStruct);
        }

        public List<StudioStruct> GetAll()
        {
            List<StudioStruct> studioStructList = new List<StudioStruct>();
            foreach (StudioStruct studioStruct in StudioContext.GetAll())
            {
                studioStructList.Add(studioStruct);
            }

            return studioStructList;
        }

        public void Remove(int id)
        {
            StudioContext.Remove(id);
        }

        public void Update(StudioStruct studioStruct)
        {
            StudioContext.Update(studioStruct);
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            StudioContext.UpdateGebruikersNaam(gebruikersnaam, id);
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            StudioContext.UpdateWachtwoord(wachtwoord, id);
        }
    }
}
