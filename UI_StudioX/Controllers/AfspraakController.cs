using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace UI_StudioX.Controllers
{
    public class AfspraakController : Controller
    {


        [HttpGet]
        public IActionResult Create()
        {


            return View();
        }
    }
}