using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public class StudioStruct
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string Straat { get; private set; }
        public int HuisNummer { get; private set; }
        public string PostCode { get; private set; }
        public string WoonPlaats { get; private set; }
        public string EmailAdres { get; private set; }
        public string TelefoonNummer { get; private set; }       
        public string Gebruikersnaam { get; private set; }
        public string Wachtwoord { get; private set; }

        public StudioStruct(int id, string naam, string straat, int huisnummer, string postcode, string woonplaats,
                            string emailAdres, string telefoonNummer, string gebruikersnaam, string wachtwoord)
        {
            Id = id;
            Naam = naam;
            Straat = straat;
            HuisNummer = huisnummer;
            PostCode = postcode;
            WoonPlaats = woonplaats;
            EmailAdres = emailAdres;
            TelefoonNummer = telefoonNummer;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        public StudioStruct(string naam, string straat, int huisnummer, string postcode, string woonplaats,
            string emailAdres, string telefoonNummer, string gebruikersnaam, string wachtwoord)
        {
            Naam = naam;
            Straat = straat;
            HuisNummer = huisnummer;
            PostCode = postcode;
            WoonPlaats = woonplaats;
            EmailAdres = emailAdres;
            TelefoonNummer = telefoonNummer;
            Gebruikersnaam = gebruikersnaam;
            Wachtwoord = wachtwoord;
        }

        public StudioStruct(int id, string naam, string straat, int huisnummer, string postcode, string woonplaats,
            string emailAdres, string telefoonNummer)
        {
            Id = id;
            Naam = naam;
            Straat = straat;
            HuisNummer = huisnummer;
            PostCode = postcode;
            WoonPlaats = woonplaats;
            EmailAdres = emailAdres;
            TelefoonNummer = telefoonNummer;
        }
    }
}
