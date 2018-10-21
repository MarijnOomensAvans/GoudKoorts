using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class SpawnPoint : Track
    {
        public override bool MoveToThis(Movable movable)
        {
            return false;
        }

        public Movable SpawnMineCart()
        {
            if (Movable == null)
            {
                Movable = new MineCart(this);            
            }
            return Movable;
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