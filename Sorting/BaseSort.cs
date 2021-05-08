using System;
using System.Collections.Generic;

public abstract class BaseSort
{
    public abstract List<int> Sort();

    public virtual void Print(List<int> input)
    {
        foreach (var number in input)
        {
            Console.WriteLine($"  { number }");
        }
    }
}