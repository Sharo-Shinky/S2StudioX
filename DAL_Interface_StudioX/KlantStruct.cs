using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL_Interface_StudioX
{
    public enum Gender
    {
        // LET OP, deze enum wordt ook gebruikt in de logic laag.
        // Belangrijk dat de volgorde van de set het zelfde blijft in elke laag.
        // Dit omdat er gecast wordt
        Onbekend,
        Man,
        Vrouw
    }
    public struct KlantStruct
    {
        public int Id { get; private set; }
        public string VoorNaam { get; private set; }
        public string AchterNaam { get; private set; }
        public Gender Geslacht { get; private set; }
        public DateTime GeboorteDatum { get; private set; }
        public string TelefoonNummer { get; private set; }
        public string EmailAdres { get; private set; }
        public string Straat { get; private set; }
        public int HuisNummer { get; private set; }
        public string PostCode { get; private set; }
        public string WoonPlaats { get; private set; }
        public string Gebruikersnaam { get; }
        public string Wachtwoord { get; private set; }

        public KlantStruct(int id, string voornaam, string achternaam, Gender geslacht, DateTime geboorteDatum, string telefoonnummer,
            string emailadres, string straat, int huisnummer, string postcode, string woonplaats, string gebruikernaam, string wachtwoord)
        {
            Id = id;
            VoorNaam = voornaam;
            AchterNaam = achternaam;
            Geslacht = geslacht;
            GeboorteDatum = geboorteDatum;
            TelefoonNummer = telefoonnummer;
            EmailAdres = emailadres;
            Straat = straat;
            HuisNummer = huisnummer;
            PostCode = postcode;
            WoonPlaats = woonplaats;
            Gebruikersnaam = gebruikernaam;
            Wachtwoord = wachtwoord;
        }

        public KlantStruct(int id, string voornaam, string achternaam, int geslacht, DateTime geboorteDatum, string telefoonnummer,
            string emailadres, string straat, int huisnummer, string postcode, string woonplaats, string gebruikernaam, string wachtwoord)
        {
            Id = id;
            VoorNaam = voornaam;
            AchterNaam = achternaam;
            Geslacht = (Gender)geslacht;
            GeboorteDatum = geboorteDatum;
            TelefoonNummer = telefoonnummer;
            EmailAdres = emailadres;
            Straat = straat;
            HuisNummer = huisnummer;
            PostCode = postcode;
            WoonPlaats = woonplaats;
            Gebruikersnaam = gebruikernaam;
            Wachtwoord = wachtwoord;
        }
    }
}
