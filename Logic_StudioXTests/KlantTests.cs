using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic_StudioX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Logic_Interface_StudioX;
using Logic_StudioXTests;
using DAL_StudioX;
using Enums;

namespace Logic_StudioX.Tests
{
    [TestClass()]
    public class KlantTests
    {
        private List<KlantStruct> KlantList;
        private KlantMemoryContext klantMemoryContext;

        [TestInitialize]
        public void Inittialize()
        {
            KlantList = new List<KlantStruct>();
            klantMemoryContext = new KlantMemoryContext();
        }

        [TestMethod()]
        public void GetAll_Klanten_Test()
        {
            KlantList = klantMemoryContext.GetAll();

            for (int i = 0; i < KlantList.Count; i++)
            {
                Assert.AreEqual(KlantList[i].VoorNaam, klantMemoryContext.KlantStructList[i].VoorNaam);
            }
        }

        [TestMethod()]
        public void Add_Klant_Test()
        {
            KlantStruct nieuweKlantStruct = new KlantStruct("Klant4", "Achternaam4", Gender.Man, new DateTime(2019, 6, 6),
                                                            "0681826354", "email@hotmail.com", "straat", 4, "9999XZ",
                                                            "Stad4", "Gebruikersnaam4", "Wachtwoord4", 1);

            List<KlantStruct> KlantListAfterAdding = new List<KlantStruct>();

            KlantList = klantMemoryContext.GetAll();

            KlantList.Add(nieuweKlantStruct);

            Assert.AreEqual(KlantList.Count(), 4);
        }

        [TestMethod()]
        public void Remove_Klant_Test()
        {
            KlantStruct nieuweKlantStruct = new KlantStruct("Klant4", "Achternaam4", Gender.Man, new DateTime(2019, 6, 6),
                                                            "0681826354", "email@hotmail.com", "straat", 4, "9999XZ",
                                                            "Stad4", "Gebruikersnaam4", "Wachtwoord4", 1);
            KlantList = klantMemoryContext.GetAll();

            KlantList.Add(nieuweKlantStruct);

            Assert.IsTrue(KlantList.Remove(nieuweKlantStruct));
        }
    }
}