using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logic_Interface_StudioX
{
    public interface IStudio
    {
        int Id { get; }
        string Naam { get; }
        string TelefoonNummer { get; }
        string EmailAdres { get; }
        string Straat { get; }
        int HuisNummer { get; }
        string PostCode { get; }
        string WoonPlaats { get; }
        string Gebruikersnaam { get; }
        string Wachtwoord { get; }

        void UpdateStudio(IStudio studio);

        void UpdateGebruikersNaam(string gebruikersnaam, int id);

        void UpdateWachtwoord(string wachtwoord, int id);

        void MaakAfspraak(IKlant klant, IAfspraak afspraak, IInstrument instrument1 = null, IInstrument instrument2 = null);
    }
}
