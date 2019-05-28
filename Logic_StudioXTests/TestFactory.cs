using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;

namespace Logic_StudioXTests
{
    public static class TestFactory
    {
        public static IKlantRepository CreateKlantMemoryContext()
        {
            return new KlantRepository(new KlantMemoryContext());
        }

        public static IKlantCollectieRepository CreateKlantCollectieMemoryContext()
        {
            return new KlantRepository(new KlantMemoryContext());
        }

        public static IStudioRepository CreateStudioMemoryContext()
        {
            return new StudioRepository(new StudioMemoryContext());
        }

        public static IStudioCollectieRepository CreateStudioCollectieMemoryContext()
        {
            return new StudioRepository(new StudioMemoryContext());
        }

        public static IInstrumentRepository CreateInstrumentMemoryContext()
        {
            return new InstrumentRepository(new InstrumentMemoryContext());
        }

        public static IInstrumentCollectieRepository CreateInstrumentCollectieMemoryContext()
        {
            return new InstrumentRepository(new InstrumentMemoryContext());
        }

        public static IAfspraakRepository CreateAfspraakMemoryContext()
        {
            return new AfspraakRepository(new AfspraakMemoryContext());
        }

        public static IAfspraakCollectieRepository CreateAfspraakCollectieMemoryContext()
        {
            return new AfspraakRepository(new AfspraakMemoryContext());
        }
    }
}
