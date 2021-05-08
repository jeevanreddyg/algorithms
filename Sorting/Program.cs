using System;
using System.Collections.Generic;

namespace Git
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = new List<int>(){ 100,200,234,123422,3,2,34,12,67 };
            Bubble obj = new Bubble(input);
            obj.Print(obj.Sort());
        }
    }
}
