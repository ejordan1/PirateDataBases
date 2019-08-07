using System;
using System.Collections.Generic;
using System.Linq;

namespace PiratesDataBases.Models {
   public class Ship {
        public int ShipId {get; set;}

        public string ShipType {get; set;}

        public int TriCannons {get; set;}

        public int SquareCannons {get; set;}

        public int Hp {get; set;}

        public int Cost {get; set;}

    }
}

//ship builder

//fleet builder: pull from ship builder database, each ship has cost