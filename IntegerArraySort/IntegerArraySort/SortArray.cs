using System;

namespace IntegerArraySort
{
    public class SortArray
    {
        public static void QuickSort(int[] array, int first, int last)
        {
            if (array == null)
                throw new ArgumentNullException("Array cannot be null");

            if (first >= last)
                return;

            int comparable = array[first];
            int position = first;
            int length = array.Length;
            int[] temp = new int[length];
            array.CopyTo(temp, 0);

            for (int i = first + 1; i <= last; i++)
            {
                if (array[i] < comparable && position < i)
                {
                    array[i] = comparable;
                    array[position] = temp[i];
                    position = i;
                    i = position;
                }
                else if (array[i] > comparable && position > i)
                {
                    array[i] = comparable;
                    array[position] = temp[i];
                    position = i;
                }
            }
            if (position == first)
            {
                QuickSort(array, first + 1, last);
            }
            else
            {
                QuickSort(array, first, position);
                QuickSort(array, position + 1, last);
            }
        }

        public static void MergeSort(int[] array, int first, int last)
        {            
            
        if (array == null)
            throw new ArgumentNullException("Array cannot be null");

            int middle = first + (last - first) / 2;


            if (middle - first > 0)
                {
                    Console.WriteLine($"first: {first}, last:{last}");
                    MergeSort(array, first, middle);
                    MergeSort(array, middle + 1, last);
                }

                int length = array.Length;
                int[] temp = new int[length];
                array.CopyTo(temp, 0);
                
                //sort 2 array first -- middle and middle+1 -- last
                // temp - for equals
                // array - for result
                int left = first;
                int right = middle + 1;
                for (int i = first; i <= last;  i++)
                {
                    if (left > middle)
                    {
                        array[i] = temp[right];
                        right++;
                    }
                    else if (right > last)
                    {
                        array[i] = temp[left];
                        left++;
                    }
                    else if (temp[left] > temp[right])
                    {
                        array[i] = temp[right];
                        right++;
                    }
                    else
                    {
                        array[i] = temp[left];
                        left++;
                    }                 
                }
            
        }

        
    }
}
