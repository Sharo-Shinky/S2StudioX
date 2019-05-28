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
        public void Add(StudioStruct studioStruct)
        {
            throw new NotImplementedException();
        }

        public List<StudioStruct> GetAll()
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
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
