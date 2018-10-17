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
        private int _waitTime = 2000;

        public void CountDown()
        {
                var delayInterval = TimeSpan.FromMilliseconds(_waitTime);
                var runningTask = DoActionAfter(
                    delayInterval,
                    () => CountDownEnded());


                Console.ReadKey();

        }

        private void CountDownEnded()
        {
            map.MoveCarts();
            CountDown();
        }

        private Task DoActionAfter(TimeSpan delay, Action action)
        {
            return Task.Delay(delay).ContinueWith(_ => action());
        }


        }
    }