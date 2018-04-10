using System;
using System.Collections.Generic;
namespace CSharpPractice
{
   
    class MergeSort
    {
        
        

        public static void MergeSortIntList(List<int> toSort)
        {   
            int max = toSort.Count;

            List<int> temp = new List<int>();
            for(int i = 0; i < max; i ++)
            {
                temp.Add(0);
            }
            recursiveMerge(toSort, temp, 0, max-1);
        }

        public static void recursiveMerge(List<int> toSort, List<int> temp, int leftStart, int rightEnd)
        {
            if(leftStart >= rightEnd)
            {
                return;
            }
            int middle = (leftStart + rightEnd) / 2;
            recursiveMerge(toSort, temp, leftStart, middle);
            recursiveMerge(toSort, temp, middle + 1, rightEnd);
            MergeHalves(toSort, temp, leftStart, rightEnd);
        }

        public static void MergeHalves(List<int> toSort, List<int> temp, int leftStart, int rightEnd)
        {
            int leftEnd = (leftStart + rightEnd) / 2;
            int rightStart = leftEnd + 1;
            int size = rightEnd - leftStart + 1;

            int left = leftStart;
            int right = rightStart;
            int index = leftStart;

            while(left <= leftEnd && right <= rightEnd)
            {
                if(toSort[left] <= toSort[right])
                {
                    temp[index] = toSort[left];
                    left++;
                }
                else
                {
                    temp[index] = toSort[right];
                    right++;
                }
                index++;
            }

            if(left <= leftEnd)
            {
                CopyList(temp, index, toSort, left, leftEnd - left+1);
            }
            if(right <= rightEnd)
            {
                CopyList(temp, index, toSort, right, rightEnd - right+1);
            }
            
            

            CopyList(toSort, leftStart, temp, leftStart, size);
        }
        public static void CopyList(List<int> targetList, int targetListPosition, List<int> copyList, int copyListPosition, int numberOfElements)
        {
            /*
            CopyList copies a section of a list<int> into another list<int>

            targetList is the list that will have elements copied into it.
            targetListPosition is the index that "targetList" will begin to recieve copied elements at
            copyList is the list that will have elements copied from
            copyListPosition is the index it will copy from
            numberOfElements is the ammount of elements that will be copied
            */
            if((targetListPosition + numberOfElements - 1)< targetList.Count && (copyListPosition + numberOfElements - 1) < copyList.Count)
            {
                for(int i = 0; i < numberOfElements; i++)
                {
                   targetList[targetListPosition + i] = copyList[copyListPosition + i];
                }
            }
            else
            {
                Console.WriteLine("Can not copy that many elements");
            }
        }

    }
    
}
