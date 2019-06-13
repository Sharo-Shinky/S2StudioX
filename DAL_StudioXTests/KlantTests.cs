using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_StudioX;
using DAL_Interface_StudioX;
using DAL_StudioX;
using Enums;
using Logic_Interface_StudioX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL_StudioXTests
{
    [TestClass()]
    public class KlantTests
    {
        KlantCollectie klantCollectie = new KlantCollectie(TestFactory.CreateKlantCollectieSQLContext());
        Klant klant = new Klant(TestFactory.CreateKlantSQLContext());

        [TestMethod()]
        public void Get_All_Klanten_Test()
        {
            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(2, klantList.Count);
        }

        [TestMethod()]
        public void Add_Klant_Test()
        {
            Klant toeTeVoegenKlant = new Klant(new KlantStruct("Sharo", "Shinky", Gender.Man, new DateTime(1992, 8, 5),
                                                               "0634990190", "sharo-shinky@hotmail.com", "Willem van Noortlaan",
                                                               41, "5622 PL", "Eindhoven", "Sharo-Shinky", "Wachtwoord", 1));

            klantCollectie.Add(toeTeVoegenKlant);

            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(3, klantCollectie.GetAll().Count);
            Assert.AreEqual(klantList[0].VoorNaam, toeTeVoegenKlant.VoorNaam);

            
        }

        [TestMethod()]
        public void Add_And_Remove_Klant_Test()
        {   //test maken die 1 ding test
            int CountOfKlantenBeforeAdding;
            int CountOfKlantenAfterAdding;
            int CountOfKlantenAfterRemoving;
            int LastId;

            Klant toeTeVoegenKlant = new Klant(new KlantStruct("Sharo", "Shinky", Gender.Man, new DateTime(1992, 8, 5),
                "0634990190", "sharo-shinky@hotmail.com", "Willem van Noortlaan",
                41, "5622 PL", "Eindhoven", "Sharo-Shinky", "Wachtwoord", 1));

            CountOfKlantenBeforeAdding = klantCollectie.GetAll().Count;

            klantCollectie.Add(toeTeVoegenKlant);
            List<IKlant> klantList = klantCollectie.GetAll();
            CountOfKlantenAfterAdding = klantList.Count;

            LastId = klantList.Max(s => s.Id);
            klantCollectie.Remove(LastId);
            CountOfKlantenAfterRemoving = klantCollectie.GetAll().Count;

            Assert.AreEqual((CountOfKlantenBeforeAdding + 1), CountOfKlantenAfterAdding);
            Assert.AreEqual(klantList[CountOfKlantenAfterAdding - 1].VoorNaam, toeTeVoegenKlant.VoorNaam);
            Assert.AreEqual(CountOfKlantenAfterRemoving, CountOfKlantenBeforeAdding);
        }

        [TestMethod()]
        public void Update_Klant_Test()
        {
            Klant updateKlant = new Klant(new KlantStruct(4, "Roz", "Shinky", Gender.Vrouw, new DateTime(2001, 10, 17),
                "060000000", "roz-shinky@hotmail.com", "Remichweg",
                23, "5625 LK", "Eindhoven"));

            klant.UpdateKlant(updateKlant);

            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(klantList[1].VoorNaam, updateKlant.VoorNaam);
            Assert.AreEqual(klantList[1].Straat, updateKlant.Straat);
            Assert.AreEqual(klantList[1].Geslacht, updateKlant.Geslacht);
        }

        [TestMethod()]
        public void Update_Gebruikersnaam_Klant_Test()
        {
            klant.UpdateGebruikersNaam("NieuweGebruikersnaam", 4);

            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(klantList[1].Gebruikersnaam, "NieuweGebruikersnaam");
        }

        [TestMethod()]
        public void Update_Wachtwoord_Klant_Test()
        {
            klant.UpdateWachtwoord("NieuweWachtwoord", 4);

            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(klantList[1].Wachtwoord, "NieuweWachtwoord");
        }
    }
}
