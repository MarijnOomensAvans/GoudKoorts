using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Boat : Movable
    {

        public Boat()
        {
            load = 0;
        }

        public override bool Move()
        {
            if (onTrack.Next == null)
            {
                return true;
            }
            if (onTrack.Next.MoveToThis(this))
            {
                return true;
            }

            return true;
        }

        public override char Print()
        {
            if (load == 0)
            {
                return 'B';
            }
            string printString = "" + load;
            char print = printString[0];
            return print;
        }
    }
}