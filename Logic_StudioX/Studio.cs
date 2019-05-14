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
        private IAfspraakCollectieRepository AfspraakCollectieRepository = Factory.CreateAfspraakCollectieSQLContext();
        private IInstrumentCollectieRepository InstrumentCollectieRepository = Factory.CreateInstrumentCollectieSQLContext();

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

        public void AddAfspraak(AfspraakStruct afspraakStruct)
        {
            AfspraakCollectieRepository.AddAfspraak(afspraakStruct);
        }

        public void RemoveAfspraak(int id)
        {
            AfspraakCollectieRepository.RemoveAfspraak(id);
        }

        public List<Afspraak> GetAllAfspraken()
        {
            List<Afspraak> AfspraakList = new List<Afspraak>();

            foreach (AfspraakStruct afspraakStruct in AfspraakCollectieRepository.GetAllAfspraken())
            {
                AfspraakList.Add(new Afspraak(afspraakStruct));
            }

            return AfspraakList;
        }

        public void AddInstrument(InstrumentStruct instrumentStruct)
        {
            InstrumentCollectieRepository.AddInstrument(instrumentStruct);
        }

        public void RemoveInstrument(int id)
        {
            InstrumentCollectieRepository.RemoveInstrument(id);
        }

        public List<Instrument> GetAllInstrumenten()
        {
            List<Instrument> InstrumentList = new List<Instrument>();

            foreach (InstrumentStruct instrumentStruct in InstrumentCollectieRepository.GetAllInstrumenten())
            {
                InstrumentList.Add(new Instrument(instrumentStruct));
            }

            return InstrumentList;
        }
    }
}
