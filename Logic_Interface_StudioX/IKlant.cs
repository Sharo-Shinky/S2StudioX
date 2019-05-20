using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;

namespace Logic_Interface_StudioX
{
    public interface IKlant
    {
        int Id { get; }
        string VoorNaam { get; }
        string AchterNaam { get; }
        Gender Geslacht { get; }
        DateTime GeboorteDatum { get; }
        string TelefoonNummer { get; }
        string EmailAdres { get; }
        string Straat { get; }
        int HuisNummer { get; }
        string PostCode { get; }
        string WoonPlaats { get; }
        string Gebruikersnaam { get; }
        string Wachtwoord { get; }
        int StudioId { get; }

        void UpdateKlant(IKlant klant);

        void UpdateGebruikersNaam(string gebruikersnaam, int id);

        void UpdateWachtwoord(string wachtwoord, int id);

        void MaakAfspraak(IAfspraak afspraak, IInstrument instrument1 = null, IInstrument instrument2 = null);
    }
}
