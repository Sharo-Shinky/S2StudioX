using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;
using Logic_Interface_StudioX;

namespace Logic_StudioX
{
    public class KlantCollectie : IKlantCollectie
    {
        private static IKlantCollectieRepository KlantCollectieRepository = Factory.CreateKlantCollectieSQLContext();

        public void Add(IKlant klant)
        {
            KlantCollectieRepository.Add(new KlantStruct(klant.VoorNaam, klant.AchterNaam, klant.Geslacht, klant.GeboorteDatum,
                                                         klant.TelefoonNummer, klant.EmailAdres, klant.Straat, klant.HuisNummer,
                                                         klant.PostCode, klant.WoonPlaats, klant.Gebruikersnaam, klant.Wachtwoord,
                                                         klant.StudioId));
        }

        public void Remove(int id)
        {
            KlantCollectieRepository.Remove(id);
        }

        public List<IKlant> GetAll()
        {
            List<IKlant> KlantList = new List<IKlant>();
            foreach (KlantStruct klantstruct in KlantCollectieRepository.GetAll())
            {
                KlantList.Add(new Klant(klantstruct));
            }

            return KlantList;
        }
    }
}
