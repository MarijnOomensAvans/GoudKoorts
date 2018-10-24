using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{
    class WaterHarbour : Track
    {
        public override bool MoveToThis(Movable movable)
        {
                if (movable.load)
                {
                    Movable = movable;
                    movable.onTrack.Movable = null;
                    movable.onTrack = this;
                    return true;
                }

            return true;
        }

        public override char Print()
        {
            return '~';
        }
    }
}
