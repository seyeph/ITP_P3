using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    public class Configuration
    {
        public List<SavedPosition> StandardPositions = new List<SavedPosition>();
        public int EnginePause{ get; set; }


        //return the savedPosition with the name 
        //if name doesn't exist --> return null
        public SavedPosition GetMove(string name) {
            SavedPosition temp = null;
            foreach (SavedPosition p in StandardPositions) {
                if (p.Name == name) {
                    temp = p;
                    break;
                }
            }

            return temp;

        }
    }
}
