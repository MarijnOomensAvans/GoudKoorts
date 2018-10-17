using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{   //2 to 1 switch
    public class Switch2 : Track
    {
        private Track _prevUp;
        private Track _prevDown;

        private Track _previous;

        public Switch2(Track prevTrackUp, Track prevTrackDown)
        {
            _prevUp = prevTrackUp;
            _prevDown = prevTrackDown;
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

        public void SwitchSwitch()
        {
            if (Movable == null)
            {
                if (_previous == _prevUp)
                {
                    _previous.Next = null;
                    _previous = _prevDown;
                }
                else
                {
                    _previous.Next = null;
                    _previous = _prevUp;
                }
            }
        }

        public override char Print()
        {
            return 'S';
        }
    }
}
