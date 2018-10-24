using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class MineCart : Movable
    {
        private bool _load;

        public MineCart(Track t)
        {
            onTrack = t;
            _load = true;
        }

        public override bool Move()
        {            
            if (onTrack.Next == null)
            {
                return true;
            }
            if(onTrack.Next.MoveToThis(this))
            {
                return true;
            }

            return false;
        }

        public override char Print()
        {
            if (!_load)
            {
                return 'U';
            }

            return '@';
        }
    }
}