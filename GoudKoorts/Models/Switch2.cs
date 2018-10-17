using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{   //2 to 1 switch
    public class Switch2 : Track
    {
        private Track _prevUp;
        private Track _prevDown;

        public Track Previous { get; set; }

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
                if (Previous == _prevUp)
                {
                    Previous.Next = null;
                    Previous = _prevDown;
                }
                else
                {
                    Previous.Next = null;
                    Previous = _prevUp;
                }
            }
            
        }

        public override char Print()
        {
            if (Previous == _prevDown)
            {
                return '╔';
            }
            if (Previous == _prevUp)
            {
                return '╚';
            }
            return 'Q';
        }
    }
}
