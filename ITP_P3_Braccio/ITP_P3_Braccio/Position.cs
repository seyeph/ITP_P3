using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    class Position
    {

        //variablen für die Winkel
        public int BasicAngle { get; set; } //Winkel um Roboter zu drehen
        private int SoulderAngle { get; set; } 
        private int EllbowAngle { get; set; }
        private int HandAngle_hor { get; set; }
        private int HandAngle_ver { get; set; }
        private int Gripper { get; set; }


        //const
        public Position() {}



    }
}
