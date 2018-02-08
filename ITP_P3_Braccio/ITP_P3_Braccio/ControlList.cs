using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ITP_P3_Braccio
{
    public class ControlList : IEnumerable<IMovement>
    {
        private List<IMovement> controlList = new List<IMovement>();

        #region Add
        //method to add a Position or a Pause
  
        public void Add(IMovement p)
        {
            controlList.Add(p);
        }
        #endregion

        #region Remove
        public void Remove(IMovement p) {
            controlList.Remove(p);
        }
        #endregion

        #region GetEnumerator
        IEnumerator<IMovement> IEnumerable<IMovement>.GetEnumerator()
        {
            return controlList.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return controlList.GetEnumerator();
        }

        #endregion
    }
}
