using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Switch : AbstractSwitch
    {
        //Switch has 2 nexts so it can switch
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
            if (Movable != null)
            {
                return Movable.Print();
            }
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


        public override bool MoveToThis(Movable movable)
        {
            if (Movable == null)
            {
                Movable = movable;
                movable.onTrack.Movable = null;
                movable.onTrack = this;
                return true;
            }

            return false;
        }
    }
}