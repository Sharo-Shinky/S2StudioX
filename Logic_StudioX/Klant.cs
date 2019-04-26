using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
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
    public class Klant
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

        private IKlantDAL KlantDAL = Factory.CreateKlantDAL();

        public Klant(KlantStruct klantStruct)
        {
            Id = klantStruct.Id;
            VoorNaam = klantStruct.VoorNaam;
            AchterNaam = klantStruct.AchterNaam;
            Geslacht = (Gender)klantStruct.Geslacht;
            GeboorteDatum = klantStruct.GeboorteDatum;
            TelefoonNummer = klantStruct.TelefoonNummer;
            EmailAdres = klantStruct.EmailAdres;
            Straat = klantStruct.Straat;
            HuisNummer = klantStruct.HuisNummer;
            PostCode = klantStruct.PostCode;
            WoonPlaats = klantStruct.WoonPlaats;
            Gebruikersnaam = klantStruct.Gebruikersnaam;
            Wachtwoord = klantStruct.Wachtwoord;
            StudioId = klantStruct.StudioId;
        }

        public void UpdateKlant()
        {
            KlantStruct klantStruct = new KlantStruct(Id, VoorNaam, AchterNaam, (int)Geslacht, GeboorteDatum, TelefoonNummer, EmailAdres, Straat, HuisNummer, PostCode, WoonPlaats, Gebruikersnaam, Wachtwoord, StudioId);
            KlantDAL.Update(klantStruct);
        }

        void UpdateGebruikersNaam(string GebruikersNaam)
        {

        }

        void UpdateWachtwoord(string wachtwoord)
        {

        }
    }
}
