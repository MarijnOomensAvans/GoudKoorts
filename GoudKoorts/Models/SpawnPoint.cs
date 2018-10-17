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

        public void SpawnMineCart()
        {
            Movable = new MinceCart();
        }

        public override char Print()
        {
            return 'X';
        }
    }
}