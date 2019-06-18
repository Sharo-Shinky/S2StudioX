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
    public class InstrumentTests
    {
        private List<InstrumentStruct> instrumentList;
        private InstrumentRepository instrumentRepository = new InstrumentRepository(TestFactory.CreateInstrumentMemoryContext());

        [TestMethod()]
        public void Get_All_Instrument_Test()
        {

        }

        [TestMethod()]
        public void Add_Instrument_Test()
        {

        }

        [TestMethod()]
        public void Remove_Instrument_Test()
        {

        }
    }
}
