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
           
            ViewBag.shipPieces = _db.ShipPieces.Where(shipPiece => shipPiece.Stage == 1).ToArray();
            ViewBag.ships = _db.Ships.ToArray();
            
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

/*
var geometry = new THREE.BoxGeometry( thisShip.hp / 100, .2, .2 );
            if (shipPiece.team == 1){
                var material = new THREE.MeshBasicMaterial( { color: 0x00ff00 } );
            } else if (shipPiece.team == 2){
                var material = new THREE.MeshBasicMaterial( { color: 0xff0000 } );  
            } else {
                var material = new THREE.MeshBasicMaterial( { color: 0xffff00 } );  
            }
			
            var cube = new THREE.Mesh( geometry, material );
            cube.position.x = shipPiece.xPos;
            cube.position.y = shipPiece.yPos;
            
            
			cube.rotation.x += 0.01;
			cube.rotation.y += 0.01;

scene.add( cube );
 */