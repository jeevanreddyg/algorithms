using System;
using System.Collections.Generic;

namespace Duplicate
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input1 = new List<int>(){ 1,1,1,3,5,5,6 };
            Duplicates dObj = new Duplicates();
            dObj.Remove(input1);
        }
    }
}
