﻿using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Timers;

namespace GoudKoorts
{

    public class Controller
    {
        private InputView InputView;
        private OutputView OutputView;
        private Map map;
        private int _waitTime = 1;
        private System.Timers.Timer MyTimer;
        private bool Playing;
        
        public Controller()
        {
            InputView = new InputView();
            OutputView = new OutputView();
            map = new Map();
            OutputView.DrawMap(map);
            OutputView.PrintControls();

            MyTimer = new System.Timers.Timer();
            MyTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
        }

        public void Start()
        {
            MyTimer.Interval = _waitTime;
            MyTimer.Enabled = true;
            Playing = true;
            while (Playing) {
                int result = InputView.GetSwitchNumber();
                switch (result)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
                    case 1:
                        map.SwitchSwitch(1);
                        Console.Clear();
                        OutputView.DrawMap(map);
                        OutputView.PrintControls();
                        break;
                    case 2:
                        map.SwitchSwitch(2);
                        Console.Clear();
                        OutputView.DrawMap(map);
                        OutputView.PrintControls();
                        break;
                    case 3:
                        map.SwitchSwitch(3);
                        Console.Clear();
                        OutputView.DrawMap(map);
                        OutputView.PrintControls();
                        break;
                    case 4:
                        map.SwitchSwitch(4);
                        Console.Clear();
                        OutputView.DrawMap(map);
                        OutputView.PrintControls();
                        break;
                    case 5:
                        map.SwitchSwitch(5);
                        Console.Clear();
                        OutputView.DrawMap(map);
                        OutputView.PrintControls();
                        break;
                }
            
            }
        }

        private void TimerEnd()
        {
            Playing = false;
            MyTimer.Enabled = false;

            bool notCrashed = map.MoveMovables();
            if (!notCrashed)
            {
                CollisionTriggered();
            }
            OutputView.DrawMap(map);

            Random r = new Random();
            int b = r.Next(2); // TODO makes testing easier. Remove afterwards!
            if (b == 1)
            {
                map.SpawnCart();
            }
            
            OutputView.DrawMap(map);
            OutputView.PrintControls();
            if (_waitTime > 1600) //cant have it go down indefinately
            {
                _waitTime -= 100;
            }            
        }

        private void CollisionTriggered()
        {
            MyTimer.Enabled = false;
            OutputView.ShowEndScreen();
            Console.ReadKey();
            Environment.Exit(0);
        }

        private void OnTimedEvent(object source, ElapsedEventArgs e)
        {
            TimerEnd();
            Start();
        }

    }
}