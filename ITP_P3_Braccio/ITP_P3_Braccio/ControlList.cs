using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    public class ControlList
    {
        private List<Movement> controlList = new List<Movement>();

        #region Add
        //method to add a Position or a Pause
        public void Add(Position p) {
            controlList.Add(p);
        }

        public void Add(Pause p)
        {
            controlList.Add(p);
        }
        #endregion


        #region Remove
        public void Remove(Position p) {
            controlList.Remove(p);
        }

        public void Remove(Pause p) {
            controlList.Remove(p);
        }

        #endregion
    }
}
