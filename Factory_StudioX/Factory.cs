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
        public static IKlantDAL CreateKlantDAL()
        {
            return new KlantDAL();
        }

        public static IKlantCollectieDAL CreateKlantCollectieDAL()
        {
            return new KlantDAL();
        }

        public static IStudioDAL CreateStudioDAL()
        {
            return new StudioDAL();
        }

        public static IStudioCollectieDAL CreateStudioCollectieDAL()
        {
            return new StudioDAL();
        }

        public static IInstrumentDAL CreateInstrumentDAL()
        {
            return new InstrumentDAL();
        }

        public static IInstrumentCollectieDAL CreateInstrumentCollectieDAL()
        {
            return new InstrumentDAL();
        }

        public static IAfspraakDAL CreateAfspraakDAL()
        {
            return new AfspraakDAL();
        }
    }
}
