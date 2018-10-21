using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class MineCart : Movable
    {
        public override void Move()
        {
            var prevTrack = this.onTrack;
            if(this.onTrack.Next.MoveTo(this))
            {
                prevTrack.Movable = null;
            }
            
        }

        public override char Print()
        {
            return '@';
        }
    }
}