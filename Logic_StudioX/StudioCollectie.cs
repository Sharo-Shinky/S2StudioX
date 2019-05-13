using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public static class StudioCollectie
    {
        private static IStudioCollectieRepository StudioCollectieRepository = Factory.CreateStudioCollectieSQLContext();
        public static void Add(StudioStruct studioStruct)
        {
            StudioCollectieRepository.Add(studioStruct);
        }

        public static void Remove(int id)
        {
            StudioCollectieRepository.Remove(id);
        }

        public static List<Studio> GetAll()
        {
            List<Studio> StudioList = new List<Studio>();

            foreach (StudioStruct studioStruct in StudioCollectieRepository.GetAll())
            {
                StudioList.Add(new Studio(studioStruct));
            }

            return StudioList;
        }
    }
}
