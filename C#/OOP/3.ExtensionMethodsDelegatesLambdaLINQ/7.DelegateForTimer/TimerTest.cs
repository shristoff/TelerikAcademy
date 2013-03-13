using System;
using System.Threading.Tasks;

namespace DelegateForTimer
{
    class TimerTest
    {
        static void Main()
        {
            Timer timer = new Timer();
            timer.Execute(3000);
        }
    }
}
