using System;

public class Range<T> where T : IComparable<T>
{
    private T minimum;
    private T maximum;

    public Range(T minimum, T maximum)
    {
        this.minimum = minimum;
        this.maximum = maximum;
    }

    public bool IsInRange(T value)
    {
        return value.CompareTo(minimum) >= 0 &&
               value.CompareTo(maximum) <= 0;
    }

    public T Length()
    {
        dynamic min = minimum;
        dynamic max = maximum;

        return (T)(max - min);
    }
}