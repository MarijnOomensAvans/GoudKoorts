using System;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace GoudKoorts
{

    public class Controller
    {
        private InputView InputView;
        private OutputView OutputView;
        private Map map;
        private int _waitTime = 8000;

        public Controller()
        {
            InputView = new InputView();
            OutputView = new OutputView();
            map = new Map();
            OutputView.DrawMap(map);
            InputView.PrintControls();
        }

        public void CountDown()
        {
            var delayInterval = TimeSpan.FromMilliseconds(_waitTime);
            var runningTask = DoActionAfter(
                delayInterval,
                () => CountDownEnded());

            int result = InputView.GetSwitchNumber();
            switch (result)
            {
                case -1:
                    Environment.Exit(0);
                    break;
                case 1:
                    map.SwitchSwitch(1);
                    break;
                case 2:
                    map.SwitchSwitch(2);
                    break;
                case 3:
                    map.SwitchSwitch(3);
                    break;
                case 4:
                    map.SwitchSwitch(4);
                    break;
                case 5:
                    map.SwitchSwitch(5);
                    break;
            }
        }

        private void CountDownEnded()
        {
            map.MoveCarts();
            OutputView.DrawMap(map);
            InputView.PrintControls();
            _waitTime -= 100;
            CountDown();
        }

        private Task DoActionAfter(TimeSpan delay, Action action)
        {
            return Task.Delay(delay).ContinueWith(_ => action());
        }

    }
}