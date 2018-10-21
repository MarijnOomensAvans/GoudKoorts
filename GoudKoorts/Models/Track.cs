using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public abstract class Track
    {
        public virtual Track Next { get; set; }

        public Movable Movable { get; set; }

        public abstract char Print();

        public abstract bool MoveToThis(Movable movable);

    }
}