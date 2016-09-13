using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MPP_lab1
{
    public class QuickSort
    {
        private int ArrayLength;
        private MyComparer comparator= new MyComparer();
        
        
        public int[] Sort(int[] SortArray)
        {
            Quicksort(SortArray, 0, SortArray.Length-1);
            return SortArray;
        }
        private int partition(int[] array, int start, int end)
        {
            int marker = start;
            for (int i = start; i <= end; i++)
            {
                if (!(comparator.Compare( array[i] , array[end])==1))
                {
                    int temp = array[marker]; 
                    array[marker] = array[i];
                    array[i] = temp;
                    marker += 1;
                }
            }
            return marker - 1;
        }

        private void Quicksort(int[] array, int start, int end)
        {
            if (!(comparator.Compare(start, end)==-1))
            {
                return;
            }
            int pivot = partition(array, start, end);
            Quicksort(array, start, pivot - 1);
            Quicksort(array, pivot + 1, end);
        }
    }
}
