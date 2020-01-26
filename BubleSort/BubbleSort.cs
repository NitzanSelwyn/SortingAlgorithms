using System;
using System.Collections.Generic;
using System.Text;

namespace BubleSort
{
    class BubbleSort
    {
        public void Sort(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = 1; j < arr.Length; j++)
                {
                    if (arr[j] < arr[j - 1])
                        Sawp(arr, j, j - 1);
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
