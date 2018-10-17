using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Switch : Track
    {
        //Switch has 2 nexts so is can switch
        private Track _nextUp;
        private Track _nextDown;

        public Switch()
        {
            if (Next == _nextDown)
            {
                Next = _nextUp;
            }
            else
            {
                Next = _nextDown;
            }
        }

    public override char Print()
        {
            return 'S';
        }
    }
}