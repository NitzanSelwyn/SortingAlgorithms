using System;
using System.Collections.Generic;
using System.Text;

namespace SelectionSort
{
    class SelectionSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                var minIndex = i;
                for (int j = i; j < arr.Length; j++)
                {
                    if (arr[j] < arr[minIndex])
                        minIndex = j;

                    Sawp(arr, minIndex, i);
                }
            }
        }

        private void Sawp(int[] arr, int index1, int index2)
        {
            var temp = arr[index1];
            arr[index1] = arr[index2];
            arr[index2] = temp;
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
