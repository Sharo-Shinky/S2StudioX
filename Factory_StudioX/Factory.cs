using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_StudioX;
using DAL_Interface_StudioX;

namespace Factory_StudioX
{
    public static class Factory
    {
        public static IKlantRepository CreateKlantSQLContext()
        {
            return new KlantRepository(new KlantSQLContext());
        }

        public static IKlantCollectieRepository CreateKlantCollectieSQLContext()
        {
            return new KlantRepository(new KlantSQLContext());
        }

        public static IStudioRepository CreateStudioSQLContext()
        {
            return new StudioRepository(new StudioSQLContext());
        }

        public static IStudioCollectieRepository CreateStudioCollectieSQLContext()
        {
            return new StudioRepository(new StudioSQLContext());
        }

        public static IInstrumentRepository CreateInstrumentSQLContext()
        {
            return new InstrumentRepository(new InstrumentSQLContext());
        }

        public static IInstrumentCollectieRepository CreateInstrumentCollectieSQLContext()
        {
            return new InstrumentRepository(new InstrumentSQLContext());
        }

        public static IAfspraakRepository CreateAfspraakSQLContext()
        {
            return new AfspraakRepository(new AfspraakSQLContext());
        }

        public static IAfspraakCollectieRepository CreateAfspraakCollectieSQLContext()
        {
            return new AfspraakRepository(new AfspraakSQLContext());
        }
    }
}
