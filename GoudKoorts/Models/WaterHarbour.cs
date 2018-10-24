using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{
    class WaterHarbour : Track
    {
        public override bool MoveToThis(Movable movable)
        {
            throw new NotImplementedException();
        }

        public override char Print()
        {
            return '~';
        }
    }
}
