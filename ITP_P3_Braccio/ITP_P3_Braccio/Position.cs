using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    class Position
    {

        //Getter / Setter für Winkel
        public int BasicAngle { get; set; } //Winkel um Roboter zu drehen
        public int SoulderAngle { get; set; } 
        public int EllbowAngle { get; set; }
        public int HandAngle_hor { get; set; }
        public int HandAngle_ver { get; set; }
        public int Gripper { get; set; }

        //const
        public Position() {}

        //überladender Konstruktuor mit allen Winkeln
        public Position(int BasicAngle, int SoulderAngle, int EllbowAngle, int HandAngle_hor, int HandAngle_ver, int Gripper) {
            this.BasicAngle = BasicAngle;
            this.SoulderAngle = SoulderAngle;
            this.EllbowAngle = EllbowAngle;
            this.HandAngle_hor = HandAngle_hor;
            this.HandAngle_ver = HandAngle_ver;
            this.Gripper = Gripper;
        }

    }
}
