/*  1.Define a class that holds information about a mobile phone device: model, manufacturer, price, owner, 
 battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors). 
 Define 3 separate classes (class GSM holding instances of the classes Battery and Display). 
    2.Define several constructors for the defined classes that take different sets of arguments 
(the full information for the class or part of it). Assume that model and manufacturer are mandatory (the others are optional). 
All unknown data fill with null.
    3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
    4.Add a method in the GSM class for displaying all information about it. Try to override ToString().
    5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
Ensure all fields hold correct data at any given time.
    6.Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.
    7.Write a class GSMTest to test the GSM class:
Create an array of few instances of the GSM class.
Display the information about the GSMs in the array.
Display the information about the static property IPhone4S.
    8.Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone 
number and duration (in seconds).
    9.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
    10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
    11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and 
is provided as a parameter
    12.Write a class GSMCallHistoryTest to test the call history functionality of the GSM class.
Create an instance of the GSM class.
Add few calls.
Display the information about the calls.
Assuming that the price per minute is 0.37 calculate and print the total price of the calls in the history.
Remove the longest call from the history and calculate the total price again.
Finally clear the call history and print it. */

using System;
using System.Collections.Generic;
//1.Define a class that holds information about a mobile phone device: model, manufacturer, price, owner
public class GSM
{
    //class GSM holding instances of the classes Battery and Display
    private Battery battery = new Battery(null, 0, 0, BatteryType.Null);
    private Display display = new Display(0, 0);
    //fields holding information about a mobile phone device
    private string model;
    private string manufacturer;
    private decimal price;
    private string owner;
    //6.Add a static field IPhone4S in the GSM class to hold the information about iPhone 4S.
    static public GSM iPhone4S = new GSM("iPhone4S", "Apple");
    //constructors for the defined classes that take different sets of arguments
    public GSM(string model, string manufacturer, decimal price, string owner, 
        Battery battery, Display display)
    { 
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.battery = battery;
        this.display = display;
    }

    public GSM(string model, string manufacturer) : this(model, manufacturer, 0, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, decimal price)
        : this(model, manufacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, Battery battery, Display display)
        : this(model, manufacturer, 0, null, null, null)
    {
    }
    //5.Use properties to encapsulate the data fields inside the GSM, Battery and Display classes. 
    //Ensure all fields hold correct data at any given time.
    public string Model
    {
        get { return model; }
        set
        {
            if (value.Length == 1)
                throw new ArgumentOutOfRangeException("The model should be at least two characters");
            else
                value = this.model; 
        }
    }

    public string Manufacturer
    {
        get { return manufacturer; }
        set 
        {
            if (value.Length == 1)
                throw new ArgumentOutOfRangeException("The manufacturer should be at least two characters");
            else
                value = this.manufacturer; 
        }
    }

    public decimal Price
    {
        get { return price; }
        set 
        {
            if (value < 0)
                throw new ArgumentOutOfRangeException("The price should be a positive number");
            else
                value = this.price;
        }
    }

    public string Owner
    {
        get { return owner; }
        set
        {
            if (value.Length == 1)
                throw new ArgumentOutOfRangeException("The owner should be at least two characters");
            else
                value = this.owner;
        }
    }
    //property IPhone4S in the GSM class to hold the information about iPhone 4S.
    public static GSM IPhone4S
    {
        get { return iPhone4S; }
    }
    //9.Add a property CallHistory in the GSM class to hold a list of the performed calls. Try to use the system class List<Call>.
    public List<Call> callHistory = new List<Call>();
    //Add a method in the GSM class for displaying all information about it. Try to override ToString()
    public override string ToString()
    {
        string batteryStr = null, displayStr = null;
        if (battery != null)        //sorry for this
            batteryStr = String.Format("Battery - model: {0}, type: {1}, idle: {2}h, talk: {3}h",
            battery.Model, battery.BatteryType, battery.HoursIdle, battery.HoursTalk);
        if (display != null)        //...and this
            displayStr = String.Format("Display - size: {0}\", colors: {1}",
            display.Size, display.Colors);
        return String.Format("GSM - model: {0}, manufacturer: {1}, price: ${2}\n{3}\n{4}",
            this.model, this.manufacturer, this.price, batteryStr, displayStr);
    }
    //10.Add methods in the GSM class for adding and deleting calls from the calls history. Add a method to clear the call history.
    public void AddCall(Call call)
    {
        this.callHistory.Add(call);
    }
    //remove a call from the call history
    public void DeleteCall(Call call)
    {
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            if (call.CallDateTime == this.callHistory[i].CallDateTime)
            {
                this.callHistory.RemoveAt(i);
                i--;
            }
        }
    }
    //clear call history
    public void ClearCallHistory()
    {
        this.callHistory.Clear();
    }
    //11.Add a method that calculates the total price of the calls in the call history. Assume the price per minute is fixed and 
    //is provided as a parameter
    public decimal CalculateCallCost(decimal pricePerMinute)
    {
        decimal callTime = 0;
        for (int i = 0; i < this.callHistory.Count; i++)
        {
             callTime = callTime + this.callHistory[i].Duration;
        }
        decimal callCost = pricePerMinute * (callTime / 60);
        return callCost;
    }
    //print call cost
    public void ShowCallCost(decimal callCost)
    {
        Console.WriteLine("Your bill is: ${0:0.00}", callCost);
    }
    //print call history
    public void ShowCallInfo(List<Call> callHistory)
    {
        for (int i = 0; i < this.callHistory.Count; i++)
        {
            Console.WriteLine(this.callHistory[i].CallDateTime + " " + 
                this.callHistory[i].DialedNumber + " " + this.callHistory[i].Duration + "s");
        }
    }
}