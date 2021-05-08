using System;
using System.Collections.Generic;
public class Duplicates
{
    public void Remove(List<int> input)
    {
        int j=0;
        for (int i = 0; i < input.Count; i++)
        {
            // 1,1,1,3,5,5
            if (i < input.Count - 1 && input[i] == input[i+1])
                continue;

            input[j++] = input[i];
        }

        for (int k = 0; k < j; k++)
        {
            Console.Write($" { input[k] }");
        }
    }
}