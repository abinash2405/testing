using System;
namespace Binarysearch
{
    public class sortingArray
    {
        public sortingArray()

        {

            //inital array
            int[] employeeID = { 72, 22, 32, 42, 52, 12 };


            for (int i=0; i<employeeID.Length; i++)
            {

                Console.WriteLine(employeeID[i]);


            }

            Console.ReadLine();

            Array.Sort(employeeID);
            Console.ReadLine();





        }
    }
}
