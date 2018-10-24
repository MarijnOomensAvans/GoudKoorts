using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{   //2 to 1 switch
    public class Switch2 : AbstractSwitch
    {
        private Track _prevUp;
        private Track _prevDown;

        public Track Previous { get; set; }

        public Switch2(Track prevTrackUp, Track prevTrackDown)
        {
            _prevUp = prevTrackUp;
            _prevDown = prevTrackDown;
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

        public override void SwitchSwitch()
        {
            if (Movable == null)
            {
                if (Previous == _prevUp)
                {
                    _prevUp.Next = null;
                    _prevDown.Next = this;
                    Previous = _prevDown;
                }
                else
                {
                    _prevDown.Next = null;
                    _prevUp.Next = this;
                    Previous = _prevUp;
                }
            }
            
        }

        public override char Print()
        {
            if (Movable != null)
            {
                return Movable.Print();
            }
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
