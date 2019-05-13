using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class KlantRepository : IKlantRepository, IKlantCollectieRepository
    {
        private IKlantContext KlantContext;

        public KlantRepository(IKlantContext klantContext)
        {
            KlantContext = klantContext;
        }

        public void Add(KlantStruct klantStruct)
        {
            KlantContext.Add(klantStruct);
        }

        public List<KlantStruct> GetAll()
        {
            List<KlantStruct> klantStructList = new List<KlantStruct>();
            foreach (KlantStruct klantStruct in KlantContext.GetAll())
            {
                klantStructList.Add(klantStruct);
            }

            return klantStructList;
        }

        public void Remove(int id)
        {
            KlantContext.Remove(id);
        }

        public void Update(KlantStruct klantStruct)
        {
            KlantContext.Update(klantStruct);
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            KlantContext.UpdateGebruikersNaam(gebruikersnaam, id);
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            KlantContext.UpdateWachtwoord(wachtwoord, id);
        }
    }
}
