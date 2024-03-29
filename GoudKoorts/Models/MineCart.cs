﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class MineCart : Movable
    {

        public MineCart(Track t)
        {
            onTrack = t;
            load = 1;
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
            if (load == 0)
            {
                return 'o';
            }

            return 'ö';
        }
    }
}