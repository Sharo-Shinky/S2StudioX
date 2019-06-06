using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_StudioX;
using DAL_Interface_StudioX;
using Enums;
using Logic_Interface_StudioX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL_StudioXTests
{
    [TestClass()]
    public class KlantTests
    {

        private KlantCollectie klantCollectie = new KlantCollectie();
        [TestMethod()]
        public void Get_All_Klanten_Test()
        {
            List<IKlant> klantList = klantCollectie.GetAll();

            Assert.AreEqual(klantList.Count(), 1);
        }

        [TestMethod()]
        public void Add_Klant_Test()
        {
            IKlant toeTeVoegenKlant = new Klant(new KlantStruct(1, "Sharo", "Shinky", (int)Gender.Man, new DateTime(1992, 8, 5),
                                                               "0634990190", "sharo-shinky@hotmail.com", "Willem van Noortlaan",
                                                               41, "5622 PL", "Eindhoven", "Sharo-Shinky", "Wachtwoord", 1));

            klantCollectie.Add(toeTeVoegenKlant);

            Assert.AreEqual(klantCollectie.GetAll().Count(), 2);
        }
    }
}
