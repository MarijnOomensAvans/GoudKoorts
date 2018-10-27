using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class EndField : DefaultTrack
    {
        public override Track Next => null;

        public override bool MoveToThis(Movable movable)
        {
            movable.onTrack.Movable = null;
            return true;
        }
    }
}