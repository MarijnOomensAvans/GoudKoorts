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
            movable.onTrack.Movable = null;
            movable.onTrack = null;
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
