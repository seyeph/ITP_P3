using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    public class SavedPosition : Position
    {
        public string Name { get; set; }

        //überladender Konstruktuor mit allen Winkeln und Name
        public SavedPosition(string Name, int BasicAngle, int SoulderAngle, int EllbowAngle, int HandAngle_hor, int HandAngle_ver, int Gripper)
        {
            this.Name = Name;
            this.BasicAngle = BasicAngle;
            this.SoulderAngle = SoulderAngle;
            this.EllbowAngle = EllbowAngle;
            this.HandAngle_rot = HandAngle_hor;
            this.HandAngle_ver = HandAngle_ver;
            this.Gripper = Gripper;
        }
    }

   
}
