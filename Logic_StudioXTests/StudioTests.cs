using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Logic_StudioXTests
{
    [TestClass()]
    public class StudioTests
    {
        private List<StudioStruct> studioList;
        private StudioRepository studioRepository = new StudioRepository(TestFactory.CreateStudioMemoryContext());

        [TestMethod()]
        public void Get_All_Studio_Test()
        {

        }

        [TestMethod()]
        public void Add_Studio_Test()
        {

        }

        [TestMethod()]
        public void Remove_Studio_Test()
        {

        }
    }
}
