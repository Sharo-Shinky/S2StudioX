using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Factory_StudioX;

namespace Logic_StudioX
{
    public class Studio
    {
        public int Id { get; private set; }
        public string Naam { get; private set; }
        public string TelefoonNummer { get; private set; }
        public string EmailAdres { get; private set; }
        public string Straat { get; private set; }
        public int HuisNummer { get; private set; }
        public string PostCode { get; private set; }
        public string WoonPlaats { get; private set; }
        public string Gebruikersnaam { get; private set; }
        public string Wachtwoord { get; private set; }

        private IStudioRepository StudioRepository = Factory.CreateStudioSQLContext();

        public Studio(StudioStruct studioStruct)
        {
            Id = studioStruct.Id;
            Naam = studioStruct.Naam;
            TelefoonNummer = studioStruct.TelefoonNummer;
            EmailAdres = studioStruct.EmailAdres;
            Straat = studioStruct.Straat;
            HuisNummer = studioStruct.HuisNummer;
            PostCode = studioStruct.PostCode;
            WoonPlaats = studioStruct.WoonPlaats;
            Gebruikersnaam = studioStruct.Gebruikersnaam;
            Wachtwoord = studioStruct.Wachtwoord;
        }

        public void UpdateStudio(StudioStruct studioStruct)
        {
            StudioRepository.Update(studioStruct);
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            StudioRepository.UpdateGebruikersNaam(gebruikersnaam, id);
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            StudioRepository.UpdateWachtwoord(wachtwoord, id);
        }
    }
}
