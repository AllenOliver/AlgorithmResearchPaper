using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgorithmAnalysis
{
    public static class Tools
    {
        /// <summary>
        /// Creates an array.
        /// </summary>
        /// <returns></returns>
        public static int[] CreateArray(int size)
        {
            return new int[size];
        }

        /// <summary>
        /// Swaps the specified array.
        /// </summary>
        /// <param name="array">The array.</param>
        /// <param name="position1">The position1.</param>
        /// <param name="position2">The position2.</param>
        public static void Swap(int[] array, int position1, int position2)
        {
            int temp = array[position1]; 
            array[position1] = array[position2]; 
            array[position2] = temp; 
        }

        /// <summary>
        /// Sinkings the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] SinkingSort()
        {
            int[] arr = CreateArray(100);
            int temp;

            foreach (int i in arr)
            {
                arr[i] = new Random().Next();
            }

            for (int j = 0; j <= arr.Length - 2; j++)
            {
                for (int i = 0; i <= arr.Length - 2; i++)
                {
                    if (arr[i] > arr[i + 1])
                    {
                        temp = arr[i + 1];
                        arr[i + 1] = arr[i];
                        arr[i] = temp;
                    }

                }
            }

            return arr;
        }
        /// <summary>
        /// Selections the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] SelectionSort()
        {
            int[] arr = new int[100];
            int temp = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i + 1; j < arr.Length; j++)
                {
                    if (arr[i] > arr[j])
                    {
                        temp = arr[j];
                        arr[j] = arr[i];
                        arr[i] = temp;
                    }
                }
            }
            return arr;
        }

        /// <summary>
        /// Insertions the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] InsertionSort(int[] arr)
        {
            for (int i = 0; i < arr.Length - 1; i++)
            {
                for (int j = i + 1; j > 0; j--)
                {
                    if (arr[j - 1] > arr[j])
                    {
                        int temp = arr[j - 1];
                        arr[j - 1] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
            return arr;
        }

        #region Merge sort
        public static int[] MergeSort(int[] arr)
        {
            int[] left;
            int[] right;
            int[] result = new int[arr.Length];


            if (arr.Length <= 1)
                return arr;

            int midPoint = arr.Length / 2;

            left = new int[midPoint];


            if (arr.Length % 2 == 0)
                right = new int[midPoint];
            else
                right = new int[midPoint + 1];

            for (int i = 0; i < midPoint; i++)
                left[i] = arr[i];

            int x = 0;

            for (int i = midPoint; i < arr.Length; i++)
            {
                right[x] = arr[i];
                x++;
            }

            left = MergeSort(left);
            right = MergeSort(right);
            result = Merge(left, right);

            return result;
        }

        public static int[] Merge(int[] left, int[] right)
        {
            int resultLength = right.Length + left.Length;
            int[] result = new int[resultLength];
            int indexLeft = 0, indexRight = 0, indexResult = 0;

            while (indexLeft < left.Length || indexRight < right.Length)
            {
                if (indexLeft < left.Length && indexRight < right.Length)
                {
                    if (left[indexLeft] <= right[indexRight])
                    {
                        result[indexResult] = left[indexLeft];
                        indexLeft++;
                        indexResult++;
                    }
                    else
                    {
                        result[indexResult] = right[indexRight];
                        indexRight++;
                        indexResult++;
                    }
                }
                else if (indexLeft < left.Length)
                {
                    result[indexResult] = left[indexLeft];
                    indexLeft++;
                    indexResult++;
                }
                else if (indexRight < right.Length)
                {
                    result[indexResult] = right[indexRight];
                    indexRight++;
                    indexResult++;
                }

            }
            return result;
        }

        #endregion

        /// <summary>
        /// Originals the quick sort.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns></returns>
        public static int[] OriginalQuickSort(int[] arr)
        {
            return OriginalQuickSort(arr, 0, arr.Length - 1);
        }

        /// <summary>
        /// Originals the quick sort.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <param name="start">The start.</param>
        /// <param name="end">The end.</param>
        /// <returns></returns>
        public static int[] OriginalQuickSort(int[] arr, int start, int end)
        {
            int left = start;
            int right = end;

            if (left >= right)
                return null;

            while (left < right)
            {
                while (arr[left] <= arr[right] && left < right)
                    right--;
                if (left < right)
                    Swap(arr, left, right);
                while (arr[left] <= arr[right] && left < right)
                    left++;
                if (left < right)
                    Swap(arr, left, right);
            }

            OriginalQuickSort(arr, start, left - 1);
            OriginalQuickSort(arr, right + 1, end);

            return arr;
        }

        /// <summary>
        /// Medians the quick sort.
        /// </summary>
        /// <param name="arr">The arr.</param>
        /// <returns></returns>
        public static int[] MedianQuickSort(int[] arr)
        {
            return MedianQuickSort(arr, 0, arr.Length-1);
        }

        /// <summary>
        /// Sinkings the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] MedianQuickSort(int[] arr, int start, int end)
        {
            const int cutoff = 10;

            if (start + cutoff > end)
                InsertionSort(arr);
            else
            {
                int middle = (start + end) / 2;

                if(arr[middle] < arr[start])
                    Swap(arr,start,middle);

                if (arr[end] < arr[start])
                    Swap(arr, start, middle);

                if (arr[end] < arr[middle])
                    Swap(arr, start, middle);

                int pivot = arr[middle];

                Swap(arr, middle, end-1);

                int left, right;

                for (left = start, right = end - 1;;)
                {
                    while (arr[++left] < pivot)
                        ;
                    while (pivot < arr[--right])
                        ;
                    if(left < right)
                        Swap(arr, left, right);
                    else
                        break;
                }

                Swap(arr, left, end-1);

                MedianQuickSort(arr, start, left - 1);
                MedianQuickSort(arr, left + 1, end);
            }
            return arr;
        }

        /// <summary>
        /// Sinkings the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] ShellSort()
        {
            int[] arr = CreateArray(100);
            int i, j, inc, temp;
            inc = 3;
            while (inc > 0)
            {
                for (i = 0; i < arr.Length; i++)
                {
                    j = i;
                    temp = arr[i];
                    while ((j >= inc) && (arr[j - inc] > temp))
                    {
                        arr[j] = arr[j - inc];
                        j = j - inc;
                    }
                    arr[j] = temp;
                }
                if (inc / 2 != 0)
                    inc = inc / 2;
                else if (inc == 1)
                    inc = 0;
                else
                    inc = 1;
            }

            return arr;
        }

        /// <summary>
        /// Sinkings the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] CountingSort(int[] array)
        {
            int[] sortedArray = new int[array.Length];

            // find smallest and largest value
            int minVal = array[0];
            int maxVal = array[0];
            for (int i = 1; i < array.Length; i++)
            {
                if (array[i] < minVal) minVal = array[i];
                else if (array[i] > maxVal) maxVal = array[i];
            }

            // init array of frequencies
            int[] counts = new int[maxVal - minVal + 1];

            // init the frequencies
            for (int i = 0; i < array.Length; i++)
            {
                counts[array[i] - minVal]++;
            }

            // recalculate
            counts[0]--;
            for (int i = 1; i < counts.Length; i++)
            {
                counts[i] = counts[i] + counts[i - 1];
            }

            // Sort the array
            for (int i = array.Length - 1; i >= 0; i--)
            {
                sortedArray[counts[array[i] - minVal]--] = array[i];
            }

            return sortedArray;
        }

        /// <summary>
        /// Sinkings the sort.
        /// </summary>
        /// <returns></returns>
        public static int[] RadixSort(int[] arr)
        {
            int i, j;
            int[] tmp = new int[arr.Length];
            for (int shift = 31; shift > -1; --shift)
            {
                j = 0;
                for (i = 0; i < arr.Length; ++i)
                {
                    bool move = (arr[i] << shift) >= 0;
                    if (shift == 0 ? !move : move)
                        arr[i - j] = arr[i];
                    else
                        tmp[j++] = arr[i];
                }
                Array.Copy(tmp, 0, arr, arr.Length - j, j);
            }

            return arr;
        }
    }
}
