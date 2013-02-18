using System;
using System.Collections.Generic;

class AirplaneDrinks
{
    static void Main()
    {
        #if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../input.txt"));
        #endif // This section is compiled in Debug Mode only.
        DateTime start = DateTime.Now;
        int n = int.Parse(Console.ReadLine());
        int totalTeaSeats = int.Parse(Console.ReadLine());
        int totalCoffeeSeats = n - totalTeaSeats;
        char[] seats = new char[n + 1];
        string seatsStr;
        int i, maxIndexOfUnserved, toursForTea = 0, toursForCoffee = 0, restTeaSeats, restCoffeeSeats; 
        int totalTime = 0, timeToMove = 0, timeToServe = 0;
        for (i = 1; i <= n; i++)
		{
            seats[0] = 'M';
            seats[i] = 'C';
		}
        i = 1;
        while (i <= totalTeaSeats)
        {
            seats[int.Parse(Console.ReadLine())] = 'T';
            i++;
        }
        toursForTea = (int)Math.Ceiling((decimal)totalTeaSeats / 7); 
        toursForCoffee = (int)Math.Ceiling(((decimal)totalCoffeeSeats) / 7);
        while (toursForTea > 0)
        {
            restTeaSeats = totalTeaSeats < 7 ? totalTeaSeats : 7;
            seatsStr = new string(seats);
            timeToMove = 2 * (seatsStr.LastIndexOf('T'));
            while (restTeaSeats > 0)
            {
                seatsStr = new string(seats);
                maxIndexOfUnserved = seatsStr.LastIndexOf('T');
                seats[maxIndexOfUnserved] = 'S';
                timeToServe = timeToServe + 4;
                restTeaSeats--;
                totalTeaSeats--;
            }
            totalTime = totalTime + 47 + timeToMove + timeToServe;
            timeToServe = 0;
            toursForTea--;
        }

        while (toursForCoffee > 0)
        {
            restCoffeeSeats = totalCoffeeSeats < 7 ? totalCoffeeSeats : 7;
            seatsStr = new string(seats);
            timeToMove = 2 * seatsStr.LastIndexOf('C');
            while (restCoffeeSeats > 0)
            {
                seatsStr = new string(seats);
                maxIndexOfUnserved = seatsStr.LastIndexOf('C');
                seats[maxIndexOfUnserved] = 'S';
                timeToServe = timeToServe + 4;
                restCoffeeSeats--;
                totalCoffeeSeats--;
            }
            totalTime = totalTime + 47 + timeToMove + timeToServe;
            timeToServe = 0;
            toursForCoffee--;
        }
        Console.WriteLine(totalTime);
        DateTime end = DateTime.Now;
        Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}