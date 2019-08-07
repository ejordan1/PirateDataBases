using System;
using System.Collections.Generic;
using System.Linq;
using PiratesDataBases.Models;

using Microsoft.AspNetCore.Mvc;

namespace PiratesDataBases.Controllers{
    public class ShipController : Controller {
        
        private readonly PiratesDataBasesContext _db;
        public ShipController(PiratesDataBasesContext db)
        {
            _db = db;
        }

        [HttpGet("/Ship/Index")]
        public ActionResult Index(){
            Console.WriteLine("WerE TRYING TO gET ouR VIEWs to wOrK");
            List<Ship> ships = _db.Ships.ToList();
            return View(ships);
        }

        // [HttpGet("/Ship/create")]
        public ActionResult Create(){
            return View();
        }

        [HttpPost("/Ship/Create")]
        public ActionResult Create(Ship ship){
            Console.WriteLine("SHIP/CREATE CONTROLLER");
            _db.Ships.Add(ship);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}

//create "new" view

//
