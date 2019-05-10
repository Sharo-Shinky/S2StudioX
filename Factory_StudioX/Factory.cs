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

        public static IStudioRepository CreateStudioDAL()
        {
            return new StudioSQLContext();
        }

        public static IStudioCollectieRepository CreateStudioCollectieDAL()
        {
            return new StudioSQLContext();
        }

        public static IInstrumentRepository CreateInstrumentDAL()
        {
            return new InstrumentSQLContext();
        }

        public static IInstrumentCollectieRepository CreateInstrumentCollectieDAL()
        {
            return new InstrumentSQLContext();
        }

        public static IAfspraakRepository CreateAfspraakDAL()
        {
            return new AfspraakSQLContext();
        }
    }
}
