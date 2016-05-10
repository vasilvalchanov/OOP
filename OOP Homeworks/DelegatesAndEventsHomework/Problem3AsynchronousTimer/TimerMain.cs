using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem3AsynchronousTimer
{
    class TimerMain
    {
        static void Main(string[] args)
        {


            var timer = new AsyncTimer(PrintMessage, 5, 600);
            timer.StartTimer();
        }

        private static void PrintMessage(string message)
        {
            Console.WriteLine("The timer was started");
        }
    }
}
