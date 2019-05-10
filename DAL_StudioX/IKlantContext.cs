using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;

namespace DAL_StudioX
{
    public interface IKlantContext
    {
        void Add(KlantStruct klantStruct);

        void Remove(int id);

        List<KlantStruct> GetAll();

        void Update(KlantStruct klantStruct);

        void UpdateGebruikersNaam(string gebruikersNaam);

        void UpdateWachtwoord(string wachtwoord);
    }
}
