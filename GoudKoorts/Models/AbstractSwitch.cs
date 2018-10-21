using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public abstract class AbstractSwitch : Track
    {
        public override abstract bool MoveToThis(Movable movable);
        public override abstract char Print();
        public abstract void SwitchSwitch();
    }
}