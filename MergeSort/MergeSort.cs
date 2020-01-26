using System;
using System.Collections.Generic;
using System.Text;

namespace MergeSort
{
    class MergeSort
    {

        public void Sort(int[] arr)
        {
            if (arr.Length < 2)
                return;


            var middle = arr.Length / 2;

            int[] left = new int[middle];
            for (int i = 0; i < middle; i++)
                left[i] = arr[i];

            int[] right = new int[arr.Length - middle];
            for (int i = middle; i < arr.Length; i++)
                right[i - middle] = arr[i];

            Sort(left);
            Sort(right);

            Merge(left, right, arr);
        }

        private void Merge(int[] left, int[] right, int[] results)
        {
            int i = 0, j = 0, k = 0;

            while (i < left.Length && j < right.Length)
            {
                if (left[i] <= right[j])
                    results[k++] = left[i++];
                else
                    results[k++] = right[j++];
            }

            while (i < left.Length)
                results[k++] = left[i++];

            while (j < right.Length)
                results[k++] = right[j++];
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
