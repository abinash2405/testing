//Abinash Kumanan
//0671007
//This program will output which fibonnaci sequence from the number the user inputs by using an iterative(for loop) method, and a recursive method
//It will not allow any negitave numbers



using System;

public class Lab4
{
    //Main method.
    public static void Main()

    {
     

        
       
            //Calling FibIte
            Console.WriteLine("The nth Fibonnaci Sequence calculated using iteration is {0}", FibIte(-8));
            //Calling FibRec 
            Console.WriteLine("The nth Fibonnaci Sequence calculated using recurisive is {0}", FibRec(-8));

        



 }

 
    //method to calculate the fibonnaci sequence using iteration.
    public static int FibIte(int n)
    {
        //Base case; the fibonnaci sequence has to start with etheir 1 or zero

        //first case
        int a = 0;

        //second case
        int b = 1;

         //If user inputs negitave number it will give an error message and return the same value
        if (n < 1)
        {
            //error message
            Console.WriteLine("Error cannot input negitave number");
            return n;
          

        }



        // steps to get Fibonacci sequence iteratively.
        for (int i = 0; i < n; i++)
        {

            int temp = a;
            a = b;
            b = temp + b;
        }
        //returns value a
        return a;



    }

    //method to calculate the Fibonacci sequence recursively.
    public static int FibRec(int n)
    {
        //base case 
        if (n == 1)
        {
            //n == 1 we return 1
            return 1;

        }
        //if n==0 return zero.
        if (n == 0)
        {

            return 0;
        }

        //If user inputs negitave number it will give an error message and return the same value
        if (n < 1)
        {
            //error message
            Console.WriteLine("Error cannot input negitave number");
            return n;


        }


        else
        {
            //calculates the fibonacci sequence recursivley by falling the FibRec function again and again until in returns 1 or zero
            return FibRec(n - 1) + FibRec(n - 2);
        }

    }


}





    








