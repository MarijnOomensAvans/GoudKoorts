using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{
    public class WaterHarbour : Track
    {
        public override bool MoveToThis(Movable movable)
        {
            if (movable.load > 7)
            {
                Controller.Score += 10;
                Movable = movable;
                movable.onTrack.Movable = null;
                movable.onTrack = this;
                return true;
            }

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
