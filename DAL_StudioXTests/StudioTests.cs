using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using DAL_Interface_StudioX;
using Logic_Interface_StudioX;
using Logic_StudioX;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace DAL_StudioXTests
{
    [TestClass()]
    public class StudioTests
    {
        StudioCollectie studioCollectie = new StudioCollectie(TestFactory.CreateStudioCollectieSQLContext());
        Studio studio = new Studio(TestFactory.CreateStudioSQLContext());
        Studio studioInstrument = new Studio(TestFactory.CreateInstrumentCollectieSQLContext());
        Studio studioAfspraak = new Studio(TestFactory.CreateAfspraakCollectieSQLContext());


        [TestMethod()]
        public void Get_All_Studio_Test()
        {
            List<IStudio> studioList = studioCollectie.GetAll();

            Assert.AreEqual(1, studioList.Count);
        }

        [TestMethod()]
        public void Add_Studio_Test()
        {
            Studio toeTeVoegenStudio = new Studio(new StudioStruct("StudioX", "StudioStraat", 1, "1234AB", "Eindhoven",
                                                                   "Studio@hotmail.com", "0612345678", "StudioX", "Wachtwoord"));
            
            studioCollectie.Add(toeTeVoegenStudio);

            List<IStudio> StudioList = studioCollectie.GetAll();

            Assert.AreEqual(2, studioCollectie.GetAll().Count);
            Assert.AreEqual(StudioList[1].Naam, toeTeVoegenStudio.Naam);

            studioCollectie.Remove(StudioList[1].Id);
        }
        
        [TestMethod()]
        public void Update_Studio_Test()
        {
            Studio voegToeStudio = new Studio(new StudioStruct("StudioX", "StudioStraat", 1, "1234AB", "Eindhoven",
                                                               "Studio@hotmail.com", "0612345678", "StudioX", "Wachtwoord"));

            studioCollectie.Add(voegToeStudio);

            List<IStudio> StudioList = studioCollectie.GetAll();

            Studio updateStudio = new Studio(new StudioStruct(StudioList[1].Id, "Test", "TestStraat", 100, "0000XX",
                                                              "Testhoven", "Test@hotmail.com", "0612345678"));
            
            studio.UpdateStudio(updateStudio);

            StudioList = studioCollectie.GetAll();

            Assert.AreEqual(updateStudio.Naam, StudioList[1].Naam);
            Assert.AreEqual(updateStudio.Straat, StudioList[1].Straat);

            studioCollectie.Remove(StudioList[1].Id);
        }

        [TestMethod()]
        public void Update_Gebruikersnaam_Studio_Test()
        {
            studio.UpdateGebruikersNaam("NieuweGebruikersnaam", 2);

            List<IStudio> StudioList = studioCollectie.GetAll();

            Assert.AreEqual(StudioList[1].Gebruikersnaam, "NieuweGebruikersnaam");
        }

        [TestMethod()]
        public void Update_Wachtwoord_Studio_Test()
        {
            studio.UpdateWachtwoord("NieuweWachtwoord", 2);

            List<IStudio> StudioList = studioCollectie.GetAll();

            Assert.AreEqual(StudioList[1].Wachtwoord, "NieuweWachtwoord");
        }

        [TestMethod()]
        public void Get_All_Instrumenten()
        {
            List<IInstrument> instrumentList = studioInstrument.GetAllInstrumenten();

            Assert.AreEqual(0, instrumentList.Count);
        }

        [TestMethod()]
        public void Add_Instrument_Test()
        {
            Instrument toeTeVoegenInstrument = new Instrument(new InstrumentStruct("Fluit", 1));

            studioInstrument.AddInstrument(toeTeVoegenInstrument);

            List<IInstrument> instrumentList = studioInstrument.GetAllInstrumenten();

            Assert.AreEqual(1, instrumentList.Count);
            Assert.AreEqual(instrumentList[0].Naam, toeTeVoegenInstrument.Naam);

            studioInstrument.RemoveInstrument(instrumentList[0].Id);
        }

        [TestMethod()]
        public void Remove_Instrument_Test()
        {
            Instrument toeTeVoegenInstrument = new Instrument(new InstrumentStruct("Fluit", 1));

            studioInstrument.AddInstrument(toeTeVoegenInstrument);

            List<IInstrument> instrumentList = studioInstrument.GetAllInstrumenten();

            studioInstrument.RemoveInstrument(instrumentList[0].Id);

            Assert.AreEqual(0, studioInstrument.GetAllInstrumenten().Count);
        }

        [TestMethod()]
        public void Update_Instrument_Test()
        {
            Instrument toeTeVoegenInstrument = new Instrument(new InstrumentStruct("Gitaar", 1));

            string nieuweNaamInstrument = "Piano";

            studioInstrument.AddInstrument(toeTeVoegenInstrument);

            List<IInstrument> instrumentList = studioInstrument.GetAllInstrumenten();
            
        }
    }
}
