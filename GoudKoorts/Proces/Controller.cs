using System;
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
        private int _waitTime = 2000;
        private System.Timers.Timer MyTimer;
        private bool Playing;

        public static int Score;

        public Controller()
        {
            InputView = new InputView();
            OutputView = new OutputView();
            map = new Map();
            OutputView.DrawMap(map, Score);
            OutputView.PrintControls();

            MyTimer = new System.Timers.Timer();
            MyTimer.Elapsed += new ElapsedEventHandler(OnTimedEvent);
            Playing = true;
            Start();
        }

        public void Start()
        {
            MyTimer.Interval = _waitTime;
            MyTimer.Enabled = true;
            while (Playing)
            {
                int result = InputView.GetSwitchNumber();
                switch (result)
                {
                    case -1:
                        Environment.Exit(0);
                        break;
                    case 1:
                        map.SwitchSwitch(1);
                        Console.Clear();
                        OutputView.DrawMap(map, Score);
                        OutputView.PrintControls();
                        break;
                    case 2:
                        map.SwitchSwitch(2);
                        Console.Clear();
                        OutputView.DrawMap(map, Score);
                        OutputView.PrintControls();
                        break;
                    case 3:
                        map.SwitchSwitch(3);
                        Console.Clear();
                        OutputView.DrawMap(map, Score);
                        OutputView.PrintControls();
                        break;
                    case 4:
                        map.SwitchSwitch(4);
                        Console.Clear();
                        OutputView.DrawMap(map, Score);
                        OutputView.PrintControls();
                        break;
                    case 5:
                        map.SwitchSwitch(5);
                        Console.Clear();
                        OutputView.DrawMap(map, Score);
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
            OutputView.DrawMap(map, Score);

            map.SpawnShip();
            if (Score > 17) //after one ship sails, remove spawn delay
            {
                map.SpawnCart();
                
            } else
            {
                Random r = new Random();
                int i = r.Next(3);
                if (i == 0) // spawn delay
                {
                    map.SpawnCart();                    
                }
            }

            OutputView.DrawMap(map, Score);
            OutputView.PrintControls();
            if (_waitTime > 1500) //cant have it go down forever
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
            Playing = true;
            Start();
        }

    }
}