using GoudKoorts.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoudKoorts
{
    public class Map
    {
        private SpawnPoint[] spawnPoints;
        private AbstractSwitch[] Switches;
        private List<Movable> mineCarts;

        public Track[] Row1 { get; }
        public Track[] Row2 { get; }
        public Track[] Row3 { get; }
        public Track[] Row4 { get; }
        public Track[] Row5 { get; }

        public Map()
        {
            Switches = new AbstractSwitch[5];
            spawnPoints = new SpawnPoint[3];
            mineCarts = new List<Movable>();
            Row1 = new Track[10];
            Row2 = new Track[23];
            Row3 = new Track[10];
            Row4 = new Track[9];
            Row5 = new Track[23];

            SpawnPoint SP1 = new SpawnPoint();
            SpawnPoint SP2 = new SpawnPoint();
            SpawnPoint SP3 = new SpawnPoint();
            spawnPoints[0] = SP1;
            spawnPoints[1] = SP2;
            spawnPoints[2] = SP3;

            DefaultTrack DT1 = new DefaultTrack();
            SP1.Next = DT1;
            DefaultTrack DT2 = new DefaultTrack();
            SP2.Next = DT2;
            DefaultTrack DT3 = new DefaultTrack();
            SP3.Next = DT3;

            DefaultTrack DT4 = new DefaultTrack();
            DT1.Next = DT4;
            DefaultTrack DT5 = new DefaultTrack();
            DT2.Next = DT5;
            DefaultTrack DT6 = new DefaultTrack();
            DT3.Next = DT6;

            DefaultTrack DT7 = new DefaultTrack();
            DT4.Next = DT7;
            DefaultTrack DT8 = new DefaultTrack();
            DT5.Next = DT8;
            DefaultTrack DT9 = new DefaultTrack();
            DT6.Next = DT9;

            Switch2 S1 = new Switch2(DT7, DT8);
            S1.Previous = DT8;
            DT8.Next = S1;

            DefaultTrack DT10 = new DefaultTrack();
            S1.Next = DT10;

            DefaultTrack DT11 = new DefaultTrack();
            DefaultTrack DT12 = new DefaultTrack();
            Switch S2 = new Switch(DT11, DT12);
            DT10.Next = S2;
            S2.Next = DT11;

            DefaultTrack DT13 = new DefaultTrack();
            DT11.Next = DT13;
            DefaultTrack DT14 = new DefaultTrack();
            DT12.Next = DT14;

            DefaultTrack DT15 = new DefaultTrack();
            DT13.Next = DT15;
            DefaultTrack DT16 = new DefaultTrack();
            DT15.Next = DT16;
            DefaultTrack DT17 = new DefaultTrack();
            DT16.Next = DT17;

            DefaultTrack DT32 = new DefaultTrack();
            DT9.Next = DT32;
            DefaultTrack DT33 = new DefaultTrack();
            DT32.Next = DT33;
            DefaultTrack DT34 = new DefaultTrack();
            DT33.Next = DT34;

            Switch2 S3 = new Switch2(DT14, DT34);
            DT34.Next = S3;
            S3.Previous = DT14;
            DefaultTrack DT20 = new DefaultTrack();
            S3.Next = DT20;

            DefaultTrack DT18 = new DefaultTrack();
            DefaultTrack DT19 = new DefaultTrack();
            DT18.Next = DT19;

            DefaultTrack DT35 = new DefaultTrack();
            Switch S4 = new Switch(DT18, DT35);
            S4.Next = DT35;
            DT20.Next = S4;

            DefaultTrack DT36 = new DefaultTrack();
            DT35.Next = DT36;
            DefaultTrack DT37 = new DefaultTrack();
            DT36.Next = DT37;
            DefaultTrack DT38 = new DefaultTrack();
            DT37.Next = DT38;
            DefaultTrack DT39 = new DefaultTrack();
            DT38.Next = DT39;
            DefaultTrack DT40 = new DefaultTrack();
            DT39.Next = DT40;
            DefaultTrack DT41 = new DefaultTrack();
            DT40.Next = DT41;
            Shunt SH1 = new Shunt();
            DT41.Next = SH1;
            Shunt SH2 = new Shunt();
            SH1.Next = SH2;
            Shunt SH3 = new Shunt();
            SH2.Next = SH3;
            Shunt SH4 = new Shunt();
            SH3.Next = SH4;
            Shunt SH5 = new Shunt();
            SH4.Next = SH5;
            Shunt SH6 = new Shunt();
            SH5.Next = SH6;
            Shunt SH7 = new Shunt();
            SH6.Next = SH7;
            Shunt SH8 = new Shunt();
            SH7.Next = SH8;

            Switch2 S5 = new Switch2(DT17, DT19);
            S5.Previous = DT17;
            DT17.Next = S5;

            DefaultTrack DT21 = new DefaultTrack();
            S5.Next = DT21;
            DefaultTrack DT22 = new DefaultTrack();
            DT21.Next = DT22;
            DefaultTrack DT23 = new DefaultTrack();
            DT22.Next = DT23;
            DefaultTrack DT24 = new DefaultTrack();
            DT23.Next = DT24;
            DefaultTrack DT25 = new DefaultTrack();
            DT24.Next = DT25;
            DefaultTrack DT26 = new DefaultTrack();
            DT25.Next = DT26;
            Harbour H1 = new Harbour();
            DT26.Next = H1;
            DefaultTrack DT27 = new DefaultTrack();
            H1.Next = DT27;
            DefaultTrack DT28 = new DefaultTrack();
            DT27.Next = DT28;
            DefaultTrack DT29 = new DefaultTrack();
            DT28.Next = DT29;
            DefaultTrack DT30 = new DefaultTrack();
            DT29.Next = DT30;
            DefaultTrack DT31 = new DefaultTrack();
            DT30.Next = DT31;
            EndField EI = new EndField();
            DT31.Next = EI;

            //fill switches list
            Switches[0] = S1;
            Switches[1] = S2;
            Switches[2] = S3;
            Switches[3] = S4;
            Switches[4] = S5;

            //fill rows
            Row1[0] = SP1;
            Row1[1] = DT1;
            Row1[2] = DT4;
            Row1[3] = DT7;
            Row1[4] = new EmptySpace();
            Row1[5] = DT11;
            Row1[6] = DT13;
            Row1[7] = DT15;
            Row1[8] = DT16;
            Row1[9] = DT17;

            Row2[0] = new EmptySpace();
            Row2[1] = new EmptySpace();
            Row2[2] = new EmptySpace();
            Row2[3] = S1;
            Row2[4] = DT10;
            Row2[5] = S2;
            Row2[6] = new EmptySpace();
            Row2[7] = new EmptySpace();
            Row2[8] = new EmptySpace();
            Row2[9] = S5;
            Row2[10] = DT21;
            Row2[11] = DT22;
            Row2[12] = DT23;
            Row2[13] = DT24;
            Row2[14] = DT25;
            Row2[15] = DT26;
            Row2[16] = H1;
            Row2[17] = DT27;
            Row2[18] = DT28;
            Row2[19] = DT29;
            Row2[20] = DT30;
            Row2[21] = DT31;
            Row2[22] = EI;

            Row3[0] = SP2;
            Row3[1] = DT2;
            Row3[2] = DT5;
            Row3[3] = DT8;
            Row3[4] = new EmptySpace();
            Row3[5] = DT12;
            Row3[6] = DT14;
            Row3[7] = new EmptySpace();
            Row3[8] = DT18;
            Row3[9] = DT19;

            Row4[0] = new EmptySpace();
            Row4[1] = new EmptySpace();
            Row4[2] = new EmptySpace();
            Row4[3] = new EmptySpace();
            Row4[4] = new EmptySpace();
            Row4[5] = new EmptySpace();
            Row4[6] = S3;
            Row4[7] = DT20;
            Row4[8] = S4;

            Row5[0] = SP3;
            Row5[1] = DT3;
            Row5[2] = DT6;
            Row5[3] = DT9;
            Row5[4] = DT32;
            Row5[5] = DT33;
            Row5[6] = DT34;
            Row5[7] = new EmptySpace();
            Row5[8] = DT35;
            Row5[9] = DT36;
            Row5[10] = DT37;
            Row5[11] = DT38;
            Row5[12] = DT39;
            Row5[13] = DT40;
            Row5[14] = DT41;
            Row5[15] = SH1;
            Row5[16] = SH2;
            Row5[17] = SH3;
            Row5[18] = SH4;
            Row5[19] = SH5;
            Row5[20] = SH6;
            Row5[21] = SH7;
            Row5[22] = SH8;
        }


        internal void SwitchSwitch(int v)
        {
            Switches[v - 1].SwitchSwitch();
        }

        internal bool MoveMovables()
        {
            foreach (Movable m in mineCarts)
            {                
                    if (!m.Move())
                    {
                        return false;
                    }                
            }
            return true;
        }

        internal void SpawnCart()
        {
            //Spawns a minecart at a random spawnpoint
            Random rand = new Random();
            int randomNumber = rand.Next(-2,3);
            mineCarts.Add(spawnPoints[randomNumber].SpawnMineCart());
        }
    }
}