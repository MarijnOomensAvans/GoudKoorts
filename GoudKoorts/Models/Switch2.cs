using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GoudKoorts.Models
{   //2 to 1 switch
    public class Switch2 : Track
    {
        public Track PrevTrack1 { get; set; }
        public Track PrevTrack2 { get; set; }

        public Switch2(Track prevTrack1, Track prevTrack2)
        {
            PrevTrack1 = prevTrack1;
            PrevTrack2 = prevTrack2;
        }

        public override char Print()
        {
            return 'S';
        }
    }
}
