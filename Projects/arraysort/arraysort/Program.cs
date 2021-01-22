



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


public class SelectionSortDemo
{
    public static void Main()
    {
        int[] values = { 5, 7, 2, 8, 9, 1 };
        // Display the unsorted array.
        Console.WriteLine("The unsorted values are:");
        for (int i = 0; i < values.Length; i++)
            Console.Write("{0} ", values[i]);
        Console.WriteLine();
        // Sort the array.
        SelectionSort(values);
        // Display the sorted array.
        Console.WriteLine("The sorted values are:");
        for (int i = 0; i < values.Length; i++)
            Console.Write("{0} ", values[i]);
        Console.WriteLine();
        Console.ReadLine();
    }

    public static void SelectionSort(int[] arr)
    {
        int smallest, temp;

        //The algorithm builds the sorted list from the left.
        //1. For each item in the array...
        for (int i = 0; i < arr.Length; i++)
        {
            //2. ...assume the first item is the smallest value
            smallest = i;
            //3. Cycle through the rest of the array
            for (int j = i + 1; j < arr.Length; j++)
            {
                //4. If any of the remaining values are smaller, find the smallest of these
                if (arr[j] < arr[smallest])
                {
                    smallest = j;
                }
            }
            //5. Swap the found-smallest value with the current value
            temp = arr[smallest];
            arr[smallest] = arr[i];
            arr[i] = temp;
        }



    }
}

