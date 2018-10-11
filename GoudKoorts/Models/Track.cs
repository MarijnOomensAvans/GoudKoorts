using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public abstract class Track
    {
        public virtual Track Next { get; set; }

        private Movable _movable;

        public abstract char Print();
    }
}