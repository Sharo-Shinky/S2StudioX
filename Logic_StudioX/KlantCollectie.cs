using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public static class KlantCollectie
    {
        private static IKlantCollectieRepository KlantCollectieRepository = Factory.CreateKlantCollectieSQLContext();

        public static void Add(KlantStruct klantStruct)
        {
            KlantCollectieRepository.Add(klantStruct);
        }

        public static void Remove(int id)
        {
            KlantCollectieRepository.Remove(id);
        }

        public static List<Klant> GetAll()
        {
            List<Klant> KlantList = new List<Klant>();
            foreach (KlantStruct klantstruct in KlantCollectieRepository.GetAll())
            {
                KlantList.Add(new Klant(klantstruct));
            }

            return KlantList;
        }
    }
}
