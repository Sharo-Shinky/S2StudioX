using Microsoft.VisualStudio.TestTools.UnitTesting;
using Logic_StudioX;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace Logic_StudioX.Tests
{
    public enum Gender
    {
        // LET OP, deze enum wordt ook gebruikt in de logic laag.
        // Belangrijk dat de volgorde van de set het zelfde blijft in elke laag.
        // Dit omdat er gecast wordt
        Onbekend,
        Man,
        Vrouw
    }
    [TestClass()]
    public class KlantCollectieTests
    {
        [TestMethod()]
        public void AddTest()
        {
            KlantStruct klantStruct = new KlantStruct(0, "Sharo", "Shinky", DAL_Interface_StudioX.Gender.Man,
                new DateTime(1992, 08, 05), "0634990190", "sharo-shinky@hotmail.com",
                "Remichweg", 23, "5625LK", "Eindhoven", "Sharo-Shinky", "Wachtwoord1");
            Klant testklant = new Klant(klantStruct);

            KlantCollectie.Add(klantStruct);

            List<Klant> klantList = KlantCollectie.GetAll();

            klantList.Reverse();

            Klant lastAdded = klantList[0];

            Assert.AreEqual(testklant.VoorNaam, lastAdded.VoorNaam);
        }

        [TestMethod()]
        public void RemoveTest()
        {
            Assert.Fail();
        }
    }
}