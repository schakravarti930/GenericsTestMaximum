﻿using System;

namespace MaxUsingGenerics
{
    class Program
    {
        static void Main(string[] args)
        {
            FindMaximum find = new FindMaximum();
            Console.WriteLine(find.MaximumIntegerNumber(10,20,30));
        }
    }
}
