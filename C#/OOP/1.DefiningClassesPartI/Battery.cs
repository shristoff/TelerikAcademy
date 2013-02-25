using System;
using System.Collections.Generic;
//3.Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.
public enum BatteryType { Null, LiPol, LiIon, NiMH, NiCd };

public class Battery
{   //fields - battery characteristics
    private string model;
    private decimal hoursIdle;
    private decimal hoursTalk;
    private BatteryType batteryType;
    //constructor for the defined Battery class
    public Battery(string model = null, int hoursIdle = 0, int hoursTalk = 0,
        BatteryType batteryType = BatteryType.Null)
    {
        this.model = model;
        this.hoursIdle = hoursIdle;
        this.hoursTalk = hoursTalk;
        this.batteryType = batteryType;
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

    public decimal HoursIdle
    {  
        get { return hoursIdle; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("The idle hours should be a positive number");
            else
                value = this.hoursIdle;
        }
    }

    public decimal HoursTalk 
    { 
        get { return hoursTalk; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("The idle hours should be a positive number");
            else
                value = this.hoursTalk;
        }
    }

    public BatteryType BatteryType
    {
        get { return batteryType; }
        set
        {
            if (Enum.IsDefined(typeof(BatteryType), value))
            {
                throw new ArgumentOutOfRangeException("The type should be LiPol, LiIon, NiMH or NiCd");
            }
            else
                value = this.batteryType;
        }
    }
}
