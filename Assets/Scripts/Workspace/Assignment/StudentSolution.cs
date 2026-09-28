using UnityEngine;
using System.Reflection;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System;


namespace Assignment
{
    public class StudentSolution : IAssignment
    {
        #region Lecture
        public int[] LCT01_SelectionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int minindex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] < numbers[minindex])
                    {
                        minindex = j;
                    }
                }
                // Swap the found minimum element with the first element
                // int temp = numbers[minindex];
                // numbers[minindex] = numbers[i];
                // numbers[i] = temp;
                (numbers[i], numbers[minindex]) = (numbers[minindex], numbers[i]);
            }

            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT02_BubbleSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n-1; i++)
            {
                for (int j = 0; j < n-i-1; j++)
                {
                   if (numbers[j] > numbers[j+1])
                   {
                       // swap temp and numbers[i]
                       int temp = numbers[j];
                       numbers[j] = numbers[j+1];
                       numbers[j+1] = temp;
                    }
                }
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        public int[] LCT03_InsertionSortAscending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 1; i < n; ++i)
            {
               int key = numbers[i];
               int j = i - 1;
                while (j >= 0 && numbers[j] > key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            foreach (var n_ in numbers)
            {
                Debug.Log(n_);
            }
            return numbers;
        }

        #endregion

        #region Assignment

        public int[] AS01_SelectionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                int maxindex = i;
                for (int j = i + 1; j < n; j++)
                {
                    if (numbers[j] > numbers[maxindex])
                    {
                        maxindex = j;
                    }
                }
                // Swap the found maximum element with the first element
                (numbers[i], numbers[maxindex]) = (numbers[maxindex], numbers[i]);
            }
            return numbers;
        }

        public int[] AS02_BubbleSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 0; i < n - 1; i++)
            {
                for (int j = 0; j < n - i - 1; j++)
                {
                    if (numbers[j] < numbers[j + 1])
                    {
                        // swap temp and numbers[i]
                        int temp = numbers[j];
                        numbers[j] = numbers[j + 1];
                        numbers[j + 1] = temp;
                    }
                }
            }
            return numbers;
        }

        public int[] AS03_InsertionSortDescending(int[] numbers)
        {
            int n = numbers.Length;
            for (int i = 1; i < n; ++i)
            {
                int key = numbers[i];
                int j = i - 1;
                while (j >= 0 && numbers[j] < key)
                {
                    numbers[j + 1] = numbers[j];
                    j--;
                }
                numbers[j + 1] = key;
            }
            return numbers;
        }

        public int AS04_FindTheSecondLargestNumber(int[] numbers)
        {
           Array.Sort(numbers);
           int n = numbers.Length;
           for (int i = n - 2; i >= 0; i--)
           {
               if (numbers[i] < numbers[n - 1])
               {
                   return numbers[i];
               }
           }

            return 0;
        }

        #endregion

        #region Extra

        public int EX01_FindLongestConsecutiveSequence(int[] numbers)
        {
            return 0;
        }

        #endregion
    }
}
