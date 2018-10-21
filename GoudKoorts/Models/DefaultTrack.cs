using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class DefaultTrack : Track
    {
        public override bool MoveToThis(Movable movable)
        {
            if (Movable == null)
            {
                Movable = movable;
                movable.onTrack.Movable = null;
                movable.onTrack = this;
                return true;
            }

            return false;
        }

        public override char Print()
        {
            if (Movable == null)
            {
                return '=';
            }
            return Movable.Print();
        }
    }
}