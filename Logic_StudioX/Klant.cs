﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Enums;
using Factory_StudioX;
using Logic_Interface_StudioX;

namespace Logic_StudioX
{
    public class Klant : IKlant
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

        private IKlantRepository KlantRepository;

        public Klant()
        {
            
        }

        public Klant(IKlantRepository klantRepository)
        {
            KlantRepository = klantRepository;
        }

        public Klant(KlantStruct klantStruct)
        {
            Id = klantStruct.Id;
            VoorNaam = klantStruct.VoorNaam;
            AchterNaam = klantStruct.AchterNaam;
            Geslacht = klantStruct.Geslacht;
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

        public Klant(IKlant klant)
        {
            Id = klant.Id;
            VoorNaam = klant.VoorNaam;
            AchterNaam = klant.AchterNaam;
            Geslacht = klant.Geslacht;
            GeboorteDatum = klant.GeboorteDatum;
            TelefoonNummer = klant.TelefoonNummer;
            EmailAdres = klant.EmailAdres;
            Straat = klant.Straat;
            HuisNummer = klant.HuisNummer;
            PostCode = klant.PostCode;
            WoonPlaats = klant.WoonPlaats;
            Gebruikersnaam = klant.Gebruikersnaam;
            Wachtwoord = klant.Wachtwoord;
            StudioId = klant.StudioId;
        }

        public void UpdateKlant(IKlant klant)
        {
            KlantRepository.Update(new KlantStruct(klant.Id, klant.VoorNaam, klant.AchterNaam, klant.Geslacht, klant.GeboorteDatum,
                                                   klant.TelefoonNummer, klant.EmailAdres, klant.Straat, klant.HuisNummer,
                                                   klant.PostCode, klant.WoonPlaats));
        }

        public void UpdateGebruikersNaam(string gebruikersnaam, int id)
        {
            KlantRepository.UpdateGebruikersNaam(gebruikersnaam, id);
        }

        public void UpdateWachtwoord(string wachtwoord, int id)
        {
            KlantRepository.UpdateWachtwoord(wachtwoord, id);
        }

        public void MaakAfspraak(IAfspraak afspraak, IInstrument instrument1 = null, IInstrument instrument2 = null)
        {
            throw new NotImplementedException();
        }
    }
}
