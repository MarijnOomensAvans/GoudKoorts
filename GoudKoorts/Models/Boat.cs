using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Boat : Movable
    {
        public override void Move()
        {
            throw new NotImplementedException();
        }

        public override char Print()
        {
            return 'B';
        }
    }
}