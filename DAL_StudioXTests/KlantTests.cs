using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Logic_StudioX;
using DAL_Interface_StudioX;
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


        }
    }
}
