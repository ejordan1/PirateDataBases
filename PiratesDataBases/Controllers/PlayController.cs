using Microsoft.AspNetCore.Mvc;
using PiratesDataBases.Models;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace PiratesDataBases.Controllers
{
    public class PlayController : Controller {
    
        public readonly PiratesDataBasesContext _db;

        public PlayController(PiratesDataBasesContext db){
            _db = db;
        }
        public ActionResult Level1()
        {
           
            ViewBag.shipPieces = _db.ShipPieces.Where(shipPiece => shipPiece.Stage == 1).ToList();
            ViewBag.ships = _db.Ships.ToList();
            return View();
        }

       
        public ActionResult Level2()
        {
            
            return View();
        }

        
        public ActionResult Level3()
        {
            return View();
        }
    }
}

//how to do this properly?