/* 7.Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it.*/

using System;
using System.Collections.Generic;

class GSMTest
{
    static void Main()
    {
        int index = 0;
        //Create an array of few instances of the GSM class.
        GSM[] phones = new GSM[3];
        Battery batteryCellPhone1 = new Battery("MadeInKorea", 120, 35, BatteryType.LiPol);
        Display displayCellPhone1 = new Display(4.5, 16000000);
        Call call1 = new Call(new DateTime(2012, 12, 23, 18, 44, 23), "+359888123456", 54);
        Call call2 = new Call(new DateTime(2012, 12, 25, 08, 33, 14), "+359888654321", 124);
        Call call3 = new Call(new DateTime(2012, 12, 26, 12, 45, 05), "+359888111111", 76);
        phones[0] = new GSM("Galaxy S2", "Samsung", 1075, "Tosho", batteryCellPhone1, displayCellPhone1);
        phones[1] = new GSM("N95", "Nokia", 75);
        phones[2] = GSM.iPhone4S;
        //Display the information about the GSMs in the array.
        foreach (var phone in phones)
        {
            Console.WriteLine(phone.ToString());
        }
        //Add few calls.
        phones[0].AddCall(call1);
        phones[0].AddCall(call2);
        phones[0].AddCall(call3);
        //Display the information about the calls.
        phones[0].ShowCallInfo(phones[0].callHistory);
        //Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
        phones[0].ShowCallCost(phones[0].CalculateCallCost(0.37m));
        //Remove the longest call from the historyand calculate the total price again.
        for (int i = 0; i < phones[0].callHistory.Count; i++)
        {
            int maxDuration = 0;
            if (maxDuration < phones[0].callHistory[i].Duration)
            {
                maxDuration = phones[0].callHistory[i].Duration;
                index = i;
            }
        }
        phones[0].DeleteCall(phones[0].callHistory[index]);
        ////Display the information about the calls.
        phones[0].ShowCallInfo(phones[0].callHistory);
        phones[0].ShowCallCost(phones[0].CalculateCallCost(0.37m));
        //Finally clear the call history and print it.
        phones[0].ClearCallHistory();
        phones[0].ShowCallInfo(phones[0].callHistory);
    }
}