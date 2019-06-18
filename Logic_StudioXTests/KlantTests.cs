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
        private List<KlantStruct> klantList;
        KlantRepository klantRepository = new KlantRepository(TestFactory.CreateKlantMemoryContext());

        [TestMethod()]
        public void Get_All_Klanten_Test()
        {
            klantList = klantRepository.GetAll();

            Assert.AreEqual(3, klantList.Count);
        }

        [TestMethod()]
        public void Add_Klant_Test_Vierde_Klant_Toevoegen()
        {
            KlantStruct nieuweKlantStruct = new KlantStruct(4, "Klant4", "Achternaam4", (int)Gender.Man, new DateTime(2019, 6, 6),
                                                            "0681826354", "email@hotmail.com", "straat", 4, "9999XZ",
                                                            "Stad4", "Gebruikersnaam4", "Wachtwoord4", 1);

            //List<KlantStruct> klantListAfterAdding = new List<KlantStruct>();

            klantList = klantRepository.GetAll();

            klantList.Add(nieuweKlantStruct);

            Assert.AreEqual(4, klantList.Count);
        }

        [TestMethod()]
        public void Remove_Klant_Test()
        {
            klantList = klantRepository.GetAll();

            klantRepository.Remove(3);

            int numberOfKlantenAfterRemoving = klantRepository.GetAll().Count;

            Assert.AreEqual(2, numberOfKlantenAfterRemoving);
        }
    }
}