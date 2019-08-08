using System;
using System.Collections.Generic;
using System.Linq;

namespace PiratesDataBases.Models{
    public class ShipPiece{

        public int ShipPieceId {get; set;}
        public string ShipType {get; set;}

        public int Team{get; set;}

        public int XPos {get; set;}

        public int YPos {get; set;}

        public int Stage {get; set;}
    }
}