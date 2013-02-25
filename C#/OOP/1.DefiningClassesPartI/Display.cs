using System;
using System.Collections.Generic;

public class Display
{
    private double size;
    private int colors;

    public Display(double size = 0, int colors = 0)
    {
        this.size = size;
        this.colors = colors;
    }

    public double Size 
    {
        get { return size; }
        set 
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("The size should be a positive number");
            else
                value = this.size;
        }
    }

    public int Colors
    {
        get { return colors; }
        set
        {
            if (value <= 0)
                throw new ArgumentOutOfRangeException("The colors should be a positive number");
            else
                value = this.colors;
        }
    }
}
