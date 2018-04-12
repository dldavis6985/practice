using System;
using System.Collections.Generic;
namespace CSharpPractice
{
    class QuickSort
    {
        public static void QuickSortIntList(List<int> toSort)
        {
            int size = toSort.Count;
            RecursiveQuickSort(toSort, 0, size-1);
        }

        public static void RecursiveQuickSort (List<int> toSort, int left, int right)
        {
            int max = toSort.Count;
            
            
            if(left < right)
            {
                int pivot = Partition(toSort, left, right);

                if(pivot > 1)
                {
                    RecursiveQuickSort(toSort, left, pivot -1);
                }
                if(pivot + 1 < right)
                {
                    RecursiveQuickSort(toSort, pivot+1, right);
                }
            }


        }

        public static int Partition(List<int> toSort, int left, int right)
        {
            int pivot = toSort[left];
            int newPivotIndex = 0;
            Boolean found = false;

            while(!found)
            {
                while(toSort[left] < pivot)
                {
                    left++;
                }

                while(toSort[right] > pivot)
                {
                    right--;
                }

                if(left < right)
                {
                    if (toSort[left] == toSort[right])
                    {
                        newPivotIndex = right;
                        found = true;
                    }
                    else
                    {
                        int temp = toSort[left];
                        toSort[left] = toSort[right];
                        toSort[right] = temp;
                    }
                }
                else
                {
                    newPivotIndex = right;
                    found = true;
                }
            }
            return newPivotIndex;
        }
    }
}