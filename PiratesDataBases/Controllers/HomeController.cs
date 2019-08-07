using System;
using System.Collections.Generic;
using System.Linq;
using PiratesDataBases.Models;
using Microsoft.AspNetCore.Mvc;

namespace PiratesDataBases.Controllers
{
    public class HomeController : Controller {
    
        [HttpGet("/")]
        public ActionResult Index()
        {
            return View();
        }
    }
}