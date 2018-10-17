using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Shunt : Track
    {
        public override bool MoveTo(Movable movable)
        {
            throw new NotImplementedException();
        }

        public override char Print()
        {
            return '-';
        }

    }
}