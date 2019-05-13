using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public interface IStudioContext
    {
        void Add(StudioStruct studioStruct);

        void Remove(int id);

        List<StudioStruct> GetAll();

        void Update(StudioStruct studioStruct);

        void UpdateGebruikersNaam(string gebruikersnaam, int id);

        void UpdateWachtwoord(string wachtwoord, int id);
    }
}
