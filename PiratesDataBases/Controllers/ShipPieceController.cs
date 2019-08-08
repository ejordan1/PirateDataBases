using System;
using System.Collections.Generic;
using System.Linq;
using PiratesDataBases.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc;

namespace PiratesDataBases.Controllers{
    public class ShipPieceController : Controller {
        
        private readonly PiratesDataBasesContext _db;
        public ShipPieceController(PiratesDataBasesContext db)
        {
            _db = db;
        }

        //list of levels, what ships are in them
        //search for level 1, level 2, level ships to represent

        [HttpGet("Shippiece/Index")]
        public ActionResult Index(){
            //for drop down list implement following things:
            List<ShipPiece> shipPieces = _db.ShipPieces.ToList();
            ViewBag.shipPieces = shipPieces;
            //ViewBag.ShipId = new SelectList(_db.Ships, "ShipId","ShipType");
            //return View(shipPieces);
            return View();
        }

        [HttpPost("Shippiece/Index")]
        public ActionResult Index(ShipPiece shipPiece){
            _db.ShipPieces.Add(shipPiece);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

       
        public ActionResult Delete(int id){
            Console.WriteLine("DELETE SHIPPIECE CONTROLLER ");
            var thisShipPiece = _db.ShipPieces.FirstOrDefault(shipPiece => shipPiece.ShipPieceId == id);
            _db.ShipPieces.Remove(thisShipPiece);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
