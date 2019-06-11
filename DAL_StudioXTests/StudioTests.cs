using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Logic_Interface_StudioX;
using Logic_StudioX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL_StudioXTests
{
    [TestClass()]
    public class StudioTests
    {
        private IStudioRepository studioRepository = TestFactory.CreateStudioSQLContext();
        private IStudioCollectieRepository studioCollectieRepository = TestFactory.CreateStudioCollectieSQLContext();
        StudioCollectie studioCollectie = new StudioCollectie();

        [TestMethod()]
        public void Get_All_Studio_Test()
        {
            List<IStudio> studioStructs = studioCollectie.GetAll();

            Assert.AreEqual(4, studioStructs.Count);
        }

        [TestMethod()]
        public void Add_Studio_Test()
        {


            StudioStruct toeTeVoegenStudioStruct = new StudioStruct("StudioX", "StudioStraat", 1, "1234AB", "Eindhoven",
                                                              "Studio@hotmail.com", "0612345678", "StudioX", "Wachtwoord");

           Studio toeTeVoegenStudio = new Studio(toeTeVoegenStudioStruct);

            studioCollectie.Add(toeTeVoegenStudio);

            List<IStudio> studioStructs = studioCollectie.GetAll();

            Assert.AreEqual(5, studioStructs.Count);
        }

        [TestMethod()]
        public void Test()
        {
            
        }
    }
}
