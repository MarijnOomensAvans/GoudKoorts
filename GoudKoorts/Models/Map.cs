using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Map
    {
        private SpawnPoint[] spawnPoints;

        public Map()
        {
            spawnPoints = new SpawnPoint[3];
        }

        internal void MoveCarts()
        {


            //Spawn a minecart at a random spawnpoint
            Random rand = new Random();
            int randomNumber = rand.Next(3);
            spawnPoints[randomNumber].SpawnMineCart();
        }
    }
}