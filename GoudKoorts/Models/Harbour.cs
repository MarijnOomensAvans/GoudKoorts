using GoudKoorts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Harbour : Track
    {
        public Water WaterHarbour { get; set; }

        public override bool MoveToThis(Movable movable)
        {
            if (Movable == null)
            {
                WaterHarbour.Movable.load++;
                movable.load--;
                Controller.Score++;
                Movable = movable;
                movable.onTrack.Movable = null;
                movable.onTrack = this;
                return true;
            }

            return false;
        }

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }
            return 'H';
        }
    }
}