/*3.Define a class InvalidRangeException<T> that holds information about an error condition related to invalid range. 
  It should hold error message and a range definition [start … end]. Write a sample application that demonstrates \
  the InvalidRangeException<int> and InvalidRangeException<DateTime> by entering numbers in the range [1..100] 
  and dates in the range [1.1.1980 … 31.12.2013].*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class InvalidRangeException<T> : ApplicationException
    where T: struct
{
    private T beginning;
    private T ending;

    public T Beginning
    {
        get { return beginning; }
    }

    public T Ending
    {
        get { return ending; }
    }

    public InvalidRangeException(T beginning, T ending)
    {
        this.beginning = beginning;
        this.ending = ending;
    }

    public InvalidRangeException(string excMessage, T beginning, T ending)
        : base(excMessage)
    {
        this.beginning = beginning;
        this.ending = ending;
    }
}
