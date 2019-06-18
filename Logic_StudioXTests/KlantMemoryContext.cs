using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;
using Enums;

namespace Logic_StudioXTests
{
    public class KlantMemoryContext : IKlantContext
    {
        private List<KlantStruct> klantStructList = new List<KlantStruct>();

        public KlantMemoryContext()
        {
            klantStructList.Add(new KlantStruct(1, "Sharo", "Shinky", (int)Gender.Man, new DateTime(1992, 8, 5), "0634990190",
                                                "sharo-shinky@hotmail.com", "Willem van Noortlaan", 41, "5622 PL",
                                                "Eindhoven", "Sharo-Shinky", "Wachtwoord", 1));

            klantStructList.Add(new KlantStruct(2, "Roz", "Shinky", (int)Gender.Vrouw, new DateTime(2001, 10, 17), "0612345678",
                                                "roz-shinky@hotmail.com", "Remichweg", 23, "5625 LK", "Eindhoven",
                                                "Roz-Shinky", "Wachtwoord", 1));

            klantStructList.Add(new KlantStruct(3, "Dilkash", "Karim", (int)Gender.Vrouw, new DateTime(1964, 2, 12), "0687654321",
                                                "nina-saleh@hotmail.com", "Remichweg", 23, "5625 LK", "Eindhoven",
                                                "DSKarim", "Wachtwoord", 1));
        }

        public void Add(KlantStruct klantStruct)
        {
            klantStructList.Add(klantStruct);
        }

        public void Remove(int id)
        {
            klantStructList.Remove(klantStructList.FirstOrDefault(klantstruct => klantstruct.Id == id));
        }

        public List<KlantStruct> GetAll()
        {
            return klantStructList;
        }

        public void Update(KlantStruct klantStruct)
        {
            KlantStruct klant = klantStructList.FirstOrDefault(klntstrct => klntstrct.Id == klantStruct.Id);
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            throw new NotImplementedException();
        }
    }
}
