using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class EmptySpace : Track
    {
        public override bool MoveToThis(Movable movable)
        {
            return false;
        }

        public override char Print()
        {
            return ' ';
        }

    }
}