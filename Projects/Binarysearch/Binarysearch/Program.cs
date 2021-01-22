using System;



    class BinarySearch
    {
        public static void Main()
        {

        //inital array
        int[] employeeID = { 12, 22, 32, 42, 52, 62 };

        int searchEmployeeID = 62;

        int x = Array.BinarySearch(employeeID, searchEmployeeID);

        Console.WriteLine(x);
        Console.ReadLine();







        }
    }

