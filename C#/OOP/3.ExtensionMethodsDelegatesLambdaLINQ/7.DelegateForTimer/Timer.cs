/*7.Using delegates write a class Timer that has can execute certain method at each t seconds.*/

using System;
using System.Threading;

namespace DelegateForTimer
{
    public delegate void DelegateForTimer();

    class Timer
    {
        //method to execute at some interval
        private void Test()
        {
            Console.WriteLine("I am a method called from a delegate at each 3 seconds");
        }
        //method that executes the method Test at given interval using a delegate instance
        public void Execute(int interval)
        { //creates a delegate instance using method Test
            DelegateForTimer delegateForTimer = this.Test;
            while (true)
            {  //call the delegate instance containing the reference to Test method
                delegateForTimer(); 
                Thread.Sleep(interval);
            }
        }
    }
}
