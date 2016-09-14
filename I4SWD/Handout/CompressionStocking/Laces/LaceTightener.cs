using System;
using CompressionStocking.Timers;

namespace CompressionStocking.Laces
{
    public class LaceTightener : ILaceTightener
    {
        private readonly Timers.ITimerCtrl _timer = new TimerCtrl();

        public void Tighten()
        {
            Console.WriteLine("The Lace has been tightened\n");
        }

        public void Loosen()
        {
            for (int i = 0; i < 40; i++)
            {
                Console.WriteLine("The Lace is loosened by a click \n");
                _timer.Timeout(100);
            }
        }
    }
}