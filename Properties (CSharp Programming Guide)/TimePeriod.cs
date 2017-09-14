using System;

class TimePeriod
{
    private double seconds; //the name field

    public double Hours // the Name property
    {
        get { return seconds / 3600; }
        set
        {
            if (value < 0 || value > 24)
                throw new ArgumentOutOfRangeException(
                      $"{nameof(value)} must be between 0 and 24.");

            seconds = value * 3600;
        }
    }
}


