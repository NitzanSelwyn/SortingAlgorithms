using System;
using System.Collections.Generic;
using System.Text;

namespace QuickSort
{
    class QuickSort
    {

        public void Sort(int[] arr)
        {
            Sort(arr, 0, arr.Length - 1);
        }
        private void Sort(int[] arr,int start,int end)
        {
            if (start >= end)
                return;

            var boundary = Partition(arr, start, end);

            Sort(arr, start, boundary - 1);
            Sort(arr, boundary + 1, end);
        }

        private int Partition(int[] arr, int start,int end)
        {
            var pivot = arr[end];
            var boundry = start - 1;

            for (int i = start; i <= end; i++)
                if (arr[i] <= pivot)
                    Sawp(arr, i, ++boundry);

            return boundry;
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
