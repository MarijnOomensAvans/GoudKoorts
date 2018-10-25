using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{
    class WaterEnd : Track
    {
        public override Track Next => null;

        public override bool MoveToThis(Movable movable)
        {
            Controller.Score += movable.load;
            movable.onTrack.Movable = null;
            return true;
        }

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }
            return '~';
        }
    }
}
