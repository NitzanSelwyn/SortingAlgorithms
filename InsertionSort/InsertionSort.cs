using System;
using System.Collections.Generic;
using System.Text;

namespace InsertionSort
{
    class InsertionSort
    {

        public void Sort(int[] arr)
        {
            for (int i = 1; i < arr.Length; i++)
            {
                var current = arr[i];
                var j = i - 1;
                while (j >= 0 && arr[j] > current)
                {
                    arr[j + 1] = arr[j];
                    j--;
                }

                arr[j + 1] = current;
            }
        }

        public string ToString(int[] arr)
        {
            var text = "";
            for (int i = 0; i < arr.Length; i++)
            {
                text += $"{arr[i]}, ";
            }

            return text;
        }
    }
}
