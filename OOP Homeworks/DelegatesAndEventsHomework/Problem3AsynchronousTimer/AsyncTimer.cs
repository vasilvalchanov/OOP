using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3AsynchronousTimer
{
    using System.Threading;

    public class AsyncTimer
    {
        

        public AsyncTimer(Action<string> action, int ticks, int timeInterval)
        {
            this.Action = action;
            this.Ticks = ticks;
            this.TimeInterval = timeInterval;
            
        }

        public Action<string> Action { get; set; }

        public int Ticks { get; set; }

        public int TimeInterval { get; set; }

        public void StartTimer()
        {
            var parallel = new Thread(this.Run);
            parallel.Start();
        }

        private void Run()
        {
            for (int i = 0; i < this.Ticks; i++)
            {
                Thread.Sleep(this.TimeInterval);
                this.Action(string.Empty);
            }
        }
    }
}
