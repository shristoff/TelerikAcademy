// 8.Create a class Call to hold a call performed through a GSM. It should contain date, time, dialed phone 
//number and duration (in seconds).
using System;
using System.Collections.Generic;

public class Call
{
    //fields
    private DateTime callDateTime = new DateTime();
    private string dialedNumber = null;
    private int callDuration = 0;
    //constructor
    public Call(DateTime callDateTime, string dialedNumber, int callDuration)
    {
        this.callDateTime = callDateTime;
        this.dialedNumber = dialedNumber;
        this.callDuration = callDuration;
    }
    //properties
    public DateTime CallDateTime
    {
        get { return callDateTime; }
        set { value = this.callDateTime; }
    }

    public string DialedNumber
    {
        get { return dialedNumber; }
        set { value = this.dialedNumber; }
    }

    public int Duration
    {
        get { return callDuration; }
        set { value = this.callDuration; }
    }
}
