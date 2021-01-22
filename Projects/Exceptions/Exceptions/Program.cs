//Abinash Kumanan
//0671007
//Decemebr,6,2019
//This code will take two numbers and prevent it to divide by zero using expection
//It will have names as catch,try and throw varibles that will help to see if theirs an expection in the program
//Having an expection will prevent any wrong user input which can cause the program to crash
//Work Cited:
//CheezyCode. “C# Exception.” C# Exception, Blogger, 23 Sept. 2017, https://www.cheezycode.com/2017/09/csharp-exception.html.
//Powell-Morse, Andrew. “.NET Exception Handling: Exception Class Hierarchy.” Airbrake Blog, 27 Mar. 2017, https://airbrake.io/blog/dotnet-exception-handling/exception-class-hierarchy.
//“C# - Exception Handling.” Tutorialspoint, https://www.tutorialspoint.com/csharp/csharp_exception_handling.htm. 
using System;

namespace Exceptions
{
    class Exception
    {
     //Method that takes value a and b and pass them on the formal partmeter to check if the number is divisible by zero
     public static double Divide(double a, double b)
     {
      //If a or b equals to zero it will run through this if stament 
      if (a == 0|| b==0)
      {
       // Signals that there is anexpection in the program and  it will throw the expection to the catch block
       throw new System.DivideByZeroException();
       }

      //if a or b doesnt rqual zero return the answer to the try block
      return a / b;

        }
        //Main method
        public static void Main()
        {
        //intilize both double varibles
        double firstNum;
        double secondNum;

         //intialize the result to zero
        double result = 0;

        //Asks the user to enter in the frist number
        Console.WriteLine("Enter the first number you want to divide");
        firstNum = Convert.ToDouble(Console.ReadLine());

        //Asks the user to enter in the second number
        Console.WriteLine("Enter the second number you want to divide");
        secondNum = Convert.ToDouble(Console.ReadLine());


        //This try block test the numbers to see if its geting divide by zero if false it should output the answer
        try
        {
        //the 2 numers will get passed through another method to see to see if any number is zero
        result = Divide(firstNum, secondNum);

         //if flase it will output the asnwer
        Console.WriteLine("{0} divded by {1} = {2}", firstNum, secondNum, result);
         }

         //If an exception has been thrown this catch block will enusure that their is an error with user input and prevent it from creating any future problems
         catch (DivideByZeroException)
         { 
          //If expection is thrown an error message
          Console.WriteLine(" Cannot divide number by 0 ");

         }
     }
  }

    






    }
    

