using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class SpawnPoint : Track
    {
        public override bool MoveTo(Movable movable)
        {
            return false;
        }

        public Movable SpawnMineCart()
        {
            if (Movable == null)
            {
                Movable = new MineCart();
                Movable.onTrack = this;
                return Movable;
            }

            return null;
        }

        public override char Print()
        {
            if (Movable == null)
            {
                return 'X';
            }

            return Movable.Print();
        }
    }
}