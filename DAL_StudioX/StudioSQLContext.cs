using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public class StudioSQLContext : IStudioRepository, IStudioCollectieRepository
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

        public void UpdateGebruikersNaam(string gebruikersnaam)
        {
            throw new NotImplementedException();
        }

        public void UpdateWachtwoord(string wachtwoord)
        {
            throw new NotImplementedException();
        }
    }
}
