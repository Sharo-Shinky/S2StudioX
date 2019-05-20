using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Logic_Interface_StudioX;
using Microsoft.AspNetCore.Mvc;
using UI_StudioX.Models;

namespace UI_StudioX.Controllers
{
    public class InstrumentController : Controller
    {
        public IActionResult Index()
        {
            Instrument instrument = new Instrument(){Naam = "Gitaar"};
            return View(instrument);
        }
    }
}