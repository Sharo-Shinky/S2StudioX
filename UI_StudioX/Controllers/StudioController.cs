using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DAL_StudioX;
using Logic_Interface_StudioX;
using Logic_StudioX;
using Microsoft.AspNetCore.Mvc;
using UI_StudioX.Models;

namespace UI_StudioX.Controllers
{
    public class StudioController : Controller
    {
        private IStudio _studio;
        public StudioController(IStudio studio)
        {
            _studio = studio;
        }
        public IActionResult GetAllInstrumenten()
        {
            List<IInstrument> instrumenlist = _studio.GetAllInstrumenten();

            return View(instrumenlist);
        }

        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
    }
}