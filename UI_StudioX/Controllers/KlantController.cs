using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Enums;
using Logic_Interface_StudioX;
using Logic_StudioX;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_StudioX.Controllers
{
    public class KlantController : Controller
    {
        private IKlantCollectie _klantCollectie;

        public KlantController(IKlantCollectie klantCollectie)
        {
            _klantCollectie = klantCollectie;
        }

        public IActionResult Index()
        {
            List<IKlant> klantList = _klantCollectie.GetAll();

            return View(klantList);
        }

        [HttpGet]
        public IActionResult AddKlant()
        {
            return View();
        }

        [HttpPost]
        public IActionResult AddKlant(FormCollection form)
        {

            string VoorNaam = Request.Form["Voornaam"];
            string AchterNaam = Request.Form["Achternaam"];
           // Gender Geslacht = (int)Request.Form["Geslacht"];

            //Gender Geslacht = (Gender)Enum.Parse(typeof(Gender)), FormCollection["Geslacht"];

            DateTime GeboorteDatum = Convert.ToDateTime(Request.Form["GeboorteDatum"]);
            string TelefoonNummer;
            string EmailAdres;
            string Straat;
            int HuisNummer;
            string PostCode;
            string WoonPlaats;
            string Gebruikersnaam;
            string Wachtwoord;

            //_klantCollectie.Add();

            return RedirectToAction();
        }
    }
}