using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class DefaultTrack : Track
    {
        public override bool MoveTo(Movable movable)
        {
            if (Movable != null)
            {
                if (Next.MoveTo(movable))
                {
                    Movable = movable;
                    return true;
                }

                return false;
            }
            Movable = movable;
            return true;

        }

        public override char Print()
        {
            return '=';
        }
    }
}