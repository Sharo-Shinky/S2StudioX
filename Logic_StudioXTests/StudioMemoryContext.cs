using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using DAL_StudioX;

namespace Logic_StudioXTests
{
    public class StudioMemoryContext : IStudioContext
    {
        private List<StudioStruct> studioStructList = new List<StudioStruct>();

        public StudioMemoryContext()
        {
            studioStructList.Add(new StudioStruct(1, "StudioX", "StudioEenStraat", 1, "1111AA", "Eenhoven",
                                                  "Studio1@hotmail.com", "0611111111", "StudioX", "Eenwoord"));

            studioStructList.Add(new StudioStruct(2, "Studio2", "StudioTweeStraat", 2, "2222BB", "Tweehoven",
                                                  "Studio2@hotmail.com", "0622222222", "Studio2", "Tweewoord"));

            studioStructList.Add(new StudioStruct(3, "Studio3", "StudioDrieStraat", 3, "3333CC", "Driehoven",
                                                  "Studio3@hotmail.com", "0633333333", "Studio3", "Driewoord"));
        }

        public void Add(StudioStruct studioStruct)
        {
            studioStructList.Add(studioStruct);
        }

        public List<StudioStruct> GetAll()
        {
            return studioStructList;
        }

        public void Remove(int id)
        {
            studioStructList.Remove(studioStructList.FirstOrDefault(studiostruct => studiostruct.Id == id));
        }

        public void Update(StudioStruct studioStruct)
        {
            throw new NotImplementedException();
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            throw new NotImplementedException();
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            throw new NotImplementedException();
        }
    }
}
