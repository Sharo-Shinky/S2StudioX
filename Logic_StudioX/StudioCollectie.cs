using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;
using Logic_Interface_StudioX;

namespace Logic_StudioX
{
    public class StudioCollectie : IStudioCollectie
    {
        private IStudioCollectieRepository StudioCollectieRepository;

        public StudioCollectie(IStudioCollectieRepository studioCollectieRepository)
        {
            StudioCollectieRepository = studioCollectieRepository;
        }

        public void Add(IStudio studio)
        {
            StudioCollectieRepository.Add(new StudioStruct(studio.Naam, studio.Straat, studio.HuisNummer, studio.PostCode,
                                                           studio.WoonPlaats, studio.EmailAdres, studio.TelefoonNummer,
                                                           studio.Gebruikersnaam, studio.Wachtwoord));
        }

        public void Remove(int id)
        {
            StudioCollectieRepository.Remove(id);
        }

        public List<IStudio> GetAll()
        {
            List<IStudio> StudioList = new List<IStudio>();

            foreach (StudioStruct studioStruct in StudioCollectieRepository.GetAll())
            {
                StudioList.Add(new Studio(studioStruct));
            }

            return StudioList;
        }
    }
}
