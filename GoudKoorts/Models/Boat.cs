using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Boat : Movable
    {
        public int LoadInShip { get; set; }

        public Boat()
        {
            LoadInShip = 0;
            load = false;
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
            return Convert.ToChar(LoadInShip);
        }
    }
}