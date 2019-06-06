using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Enums;


namespace DAL_Interface_StudioX
{
    public class KlantStruct
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
        public int StudioId { get; private set; }
        
        /// <summary>
        /// Klant constructor voor toevoegen van klant
        /// </summary>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="geslacht"></param>
        /// <param name="geboorteDatum"></param>
        /// <param name="telefoonnummer"></param>
        /// <param name="emailadres"></param>
        /// <param name="straat"></param>
        /// <param name="huisnummer"></param>
        /// <param name="postcode"></param>
        /// <param name="woonplaats"></param>
        /// <param name="gebruikernaam"></param>
        /// <param name="wachtwoord"></param>
        /// <param name="studioId"></param>
        public KlantStruct(string voornaam, string achternaam, Gender geslacht, DateTime geboorteDatum, string telefoonnummer,
            string emailadres, string straat, int huisnummer, string postcode, string woonplaats, string gebruikernaam, string wachtwoord, int studioId)
        {
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
            StudioId = studioId;
        }

        /// <summary>
        /// Klant constructor voor ophalen van klant uit de database
        /// </summary>
        /// <param name="id"></param>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="geslacht"></param>
        /// <param name="geboorteDatum"></param>
        /// <param name="telefoonnummer"></param>
        /// <param name="emailadres"></param>
        /// <param name="straat"></param>
        /// <param name="huisnummer"></param>
        /// <param name="postcode"></param>
        /// <param name="woonplaats"></param>
        /// <param name="gebruikernaam"></param>
        /// <param name="wachtwoord"></param>
        /// <param name="studioId"></param>
        public KlantStruct(int id, string voornaam, string achternaam, int geslacht, DateTime geboorteDatum, string telefoonnummer,
            string emailadres, string straat, int huisnummer, string postcode, string woonplaats, string gebruikernaam, string wachtwoord, int studioId)
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
            StudioId = studioId;
        }

        /// <summary>
        /// Klant constructor voor Updaten van klant
        /// </summary>
        /// <param name="id"></param>
        /// <param name="voornaam"></param>
        /// <param name="achternaam"></param>
        /// <param name="geslacht"></param>
        /// <param name="geboorteDatum"></param>
        /// <param name="telefoonnummer"></param>
        /// <param name="emailadres"></param>
        /// <param name="straat"></param>
        /// <param name="huisnummer"></param>
        /// <param name="postcode"></param>
        /// <param name="woonplaats"></param>
        public KlantStruct(int id, string voornaam, string achternaam, Gender geslacht, DateTime geboorteDatum, string telefoonnummer,
            string emailadres, string straat, int huisnummer, string postcode, string woonplaats)
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
        }
    }
}
