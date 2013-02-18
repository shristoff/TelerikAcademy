using System;

class AirplaneDrinks
{
    static int GetLastIndexOfTrue(bool[] seats)   //методът намира най-отдалечения пътник на който трябва да се сервира
    {
        int i = seats.Length - 1;
        for (; i >= 0; i--)
        {
            if (seats[i])
                return i;
        }
        return -1;
    }
    
    static void Main()
    {
        #if DEBUG
            Console.SetIn(new System.IO.StreamReader("../../input.txt"));
        #endif // This section is compiled in Debug Mode only.
        //DateTime start = DateTime.Now;
        int n = int.Parse(Console.ReadLine());
        int totalTeaSeats = int.Parse(Console.ReadLine());
        int totalCoffeeSeats = n - totalTeaSeats;
        bool[] seatsTea = new bool[n + 1];
        bool[] seatsCoffee = new bool[n + 1];
        int i = 1, maxIndexOfUnserved, toursForTea = 0, toursForCoffee = 0, restTeaSeats, restCoffeeSeats; 
        int totalTime = 0, timeToMove = 0, timeToServe = 0;
        for (i = 1; i <= n; i++)               //приемам първоначално, че на всички места се сервира кафе
        {
            seatsCoffee[i] = true;
        }
        i = 1;
        while (i <= totalTeaSeats)
        {
            int teaSeatNumbers = int.Parse(Console.ReadLine());
            seatsTea[teaSeatNumbers] = true;                   //маркирам местата, на които трябва да се сервира чай
            seatsCoffee[teaSeatNumbers] = false;               //размаркирам местата на които трябва да се сервира чай
            i++;
        }
        toursForTea = (int)Math.Ceiling((decimal)totalTeaSeats / 7);  //броя колко пъти ще пълни каната за да сервира чай
        toursForCoffee = (int)Math.Ceiling(((decimal)totalCoffeeSeats) / 7); //броя колко пъти ще пълни каната за да сервира кафе
        while (toursForTea > 0)
        {
            restTeaSeats = totalTeaSeats < 7 ? totalTeaSeats : 7;  //местата, на които не е сервиран чай все още са общия
            timeToMove = 2 * GetLastIndexOfTrue(seatsTea); //брой места с чай ако са повече от 7 иначе колкото са (1-7)
            while (restTeaSeats > 0)
            {
                maxIndexOfUnserved = GetLastIndexOfTrue(seatsTea);  //последното място на което трябва да сервираме
                seatsTea[maxIndexOfUnserved] = false;   //маркираме го, че е сервирано
                timeToServe = timeToServe + 4; //добавяме времето за сервиране
                restTeaSeats--;   //намаяваме останалите места за сервиране от тази кана
                totalTeaSeats--;  //намаляваме общия брой места останали за сервиране на чай
            }
            totalTime = totalTime + 47 + timeToMove + timeToServe;  //смятаме общото време до момента
            timeToServe = 0;                                        //нулираме времето за сервиране с тази кана
            toursForTea--;                                          //намаяваме необходимите турове
        }

        while (toursForCoffee > 0)
        {
            restCoffeeSeats = totalCoffeeSeats < 7 ? totalCoffeeSeats : 7;
            timeToMove = 2 * GetLastIndexOfTrue(seatsCoffee);
            while (restCoffeeSeats > 0)
            {
                maxIndexOfUnserved = GetLastIndexOfTrue(seatsCoffee);
                seatsCoffee[maxIndexOfUnserved] = false;
                timeToServe = timeToServe + 4;
                restCoffeeSeats--;
                totalCoffeeSeats--;
            }
            totalTime = totalTime + 47 + timeToMove + timeToServe;
            timeToServe = 0;
            toursForCoffee--;
        }
        Console.WriteLine(totalTime);
        //DateTime end = DateTime.Now;
        //Console.WriteLine((end - start).TotalMilliseconds + " ms.");
    }
}