/* Write a method that calculates the number of workdays between today and given date, passed as parameter. 
Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.*/

using System;

class CalculateWorkdaysFromToday
{
    static int CalculateWorkingDays(DateTime date)
    {
        bool dateIsAfterToday = true;    // булева променлива за това въведената дата е преди или след днешната
        DateTime today = DateTime.Today;  
        int calendarDays, workingDays, i = 0, j = 0;
        int year;        
        if (date <= today)                //ако въведената дата е преди днешната
        {
            calendarDays = today.Subtract(date).Days;  //календарните дни са днешната минус въведената дата
            year = date.Year;                          //годината (за празниците) е годината на въведената дата
            dateIsAfterToday = false;                  //променяме стойността на булевата променлива
        }
        else                              //ако въведената дата е след днешната
        {
            calendarDays = date.Subtract(today).Days; //календарните дни са въведенатa минус днешната дата
            year = today.Year;                        //годината (за празниците) е годината на днешната дата
        }
        DateTime[] holidays = { new DateTime(year, 01, 01), new DateTime(year, 03, 03), 
                                new DateTime(year, 05, 01), new DateTime(year, 05, 03), 
                                new DateTime(year, 05, 06), new DateTime(year, 05, 24),
                                new DateTime(year, 09, 06), new DateTime(year, 09, 22),
                                new DateTime(year, 12, 24), new DateTime(year, 12, 25),
                                new DateTime(year, 12, 26) };
        DateTime newYearsDay = new DateTime(year, 12, 31);
        workingDays = calendarDays;  //слагаме стойност на workingDays, да е колкото са календарните дни 
        for (i = 1; i < calendarDays; i++)          //за всеки един ден проверяваме дали е събота или неделя
        {                                            // и ако е намаляваме работните дни
            if (dateIsAfterToday && (today.AddDays(i).DayOfWeek == DayOfWeek.Saturday ||
                                     today.AddDays(i).DayOfWeek == DayOfWeek.Sunday))
                 workingDays--;
            if (!dateIsAfterToday && (date.AddDays(i).DayOfWeek == DayOfWeek.Saturday ||
                                      date.AddDays(i).DayOfWeek == DayOfWeek.Sunday))
                workingDays--;
                                               
            for (j = 0; j < holidays.Length; j++)          
            {                                                                           //за текущия ден проверяваме дали не е празник
                if (today.AddDays(i) == newYearsDay || date.AddDays(i) == newYearsDay)        //на всяка смяна на годината увеличаваме year
                    holidays[j] = new DateTime(year + 1, holidays[j].Month, holidays[j].Day);  //за да е актуална годината на празника, който 
                if (dateIsAfterToday && (today.AddDays(i).DayOfWeek != DayOfWeek.Saturday ||    //проверяваме
                    today.AddDays(i).DayOfWeek != DayOfWeek.Sunday) && today.AddDays(i) == holidays[j])
                    workingDays--;
                if (!dateIsAfterToday && (date.AddDays(i).DayOfWeek != DayOfWeek.Saturday ||
                    date.AddDays(i).DayOfWeek != DayOfWeek.Sunday) && date.AddDays(i) == holidays[j])
                    workingDays--;
            }
        }
        return workingDays;
    }
    
    static void Main()
    {
        Console.WriteLine("Please enter date in format YYYY, MM, DD");
        DateTime date = DateTime.Parse(Console.ReadLine());
        Console.WriteLine(CalculateWorkingDays(date));
    }
}
