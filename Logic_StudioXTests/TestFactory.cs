using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;
using Logic_Interface_StudioX;
using Logic_StudioX;

namespace Logic_StudioXTests
{
    public static class TestFactory
    {
        public static IKlantContext CreateKlantMemoryContext()
        {
            return new KlantMemoryContext();
        }

        public static IStudioContext CreateStudioMemoryContext()
        {
            return new StudioMemoryContext();
        }

        public static IInstrumentContext CreateInstrumentMemoryContext()
        {
            return new InstrumentMemoryContext();
        }

        public static IAfspraakContext CreateAfspraakMemoryContext()
        {
            return new AfspraakMemoryContext();
        }
    }
}
