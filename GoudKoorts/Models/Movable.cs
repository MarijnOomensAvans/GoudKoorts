using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public abstract class Movable
    {
        public Track onTrack;

        public abstract char Print();

        public abstract bool Move();
    }
}