using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Switch : AbstractSwitch
    {
        //Switch has 2 nexts so is can switch
        private Track _nextUp;
        private Track _nextDown;

        public Switch(Track nextUp,Track nextDown)
        {
            _nextUp = nextUp;
            _nextDown = nextDown;
        }

        public override void SwitchSwitch()
        {
            if (Movable == null)
            {
                if (Next == _nextUp)
                {
                    Next = _nextDown;
                }
                else
                {
                    Next = _nextUp;
                }
            }
        }

        public override char Print()
        {
            if (Next == _nextUp)
            {
                return '╝';
            }
            if (Next == _nextDown)
            {
                return '╗';
            }
            return 'S';
        }


        public override bool MoveTo(Movable movable)
        {
            if (Movable != null)
            {
                if (Next.MoveTo(movable))
                {
                    Movable = movable;
                    return true;
                }

                return false;
            }
            Movable = movable;
            return true;
        }
    }
}