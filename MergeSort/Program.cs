﻿using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 7, 3, 1, 4, 6, 2, 3 };
            var sort = new MergeSort();
            sort.Sort(numbers);

            Console.WriteLine(sort.ToString(numbers));
        }
    }
}
