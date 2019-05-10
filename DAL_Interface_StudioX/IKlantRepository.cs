using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public interface IKlantRepository
    {
        void Update(KlantStruct klantStruct);

        void UpdateGebruikersNaam(string gebruikersNaam);

        void UpdateWachtwoord(string wachtwoord);

    }
}
