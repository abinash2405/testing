//Abinash Kumanan
//0671007
//user will enter 2 numbers and will choose whehter they want to muliply or divide the two numbers
//There are 3 methods, one method for division, another one for multiplication and the final one that promts the user to enter the 2 numbers
//and choose wheter they want to mulitply or divide


using System;

namespace Lab3
{
    public class Lab3
    {
        public static void Main()
        {

            //calls prompt method
            prompt();






        }

        //runs through this method if user wants to multiply
        public static double multiply(double x, double y)

        {
            //formula to muiltply the 2 numbers the user inputs
            double product = x * y;


            //return the answer
            return product;
        }
        //runs through this method if user wants to divide
        public static double divide(double x, double y)
        {

            //formula to divide the 2 numbers the user input
            double result = x / y;

            //returns answer
            return result;

        }

        //runs through this method when the user is asked to input 2 numbers and wheter if they want to multiply or divide
        public static void prompt()
        {

            //varible name for the first number the user inputs
            double firstNumber;

            //varible anme for the second number the user inputs
            double secondNumber;

            //letter they enter whether they want to multiply or divide
            char operation;

            //check to see if false
            Boolean check = false;

            //runs through this loop to ceck if the user enters the first number as an integer
            do
            {
               
                //user inputs first number
                Console.WriteLine("plese enter first number ");

                //boolean check to see if its true
                check = true;

                //if statment when the user enters a letter instead of an integer
                if (!double.TryParse(Console.ReadLine(), out firstNumber))
                {
                    //boolean check will equal to false
                    check = false;
                    //error message
                    Console.WriteLine("You can only input a number");
              
                }
                //runs through this statement unitl it becomes true
            } while (check == false);

            //converts into a double 
            firstNumber = Convert.ToDouble(firstNumber);

            //runs through this loop to ceck if the user enters the second number as an integer
            do
            {
                //varible name for the second number the user inputs
                Console.WriteLine("plese enter second number ");

                //boolean check to see if its true
                check = true;



                //if statment when the user enters a letter instead of an integer
                if (!double.TryParse(Console.ReadLine(), out secondNumber))
                {
                    //boolean check will equal to false
                    check = false;

                    //error message
                    Console.WriteLine("You can only input a number");

                 //runs through this statement unitl it becomes true
                }
            } while (check == false);


            //converts into a double
            secondNumber = Convert.ToDouble(secondNumber);


            //asks the user whether they would want to mulitoly or divide
            Console.WriteLine("would you like to multiply or divide (insert either m or d)");
                operation = Convert.ToChar(Console.ReadLine());

                //runs through this statement if user wants to divide
                if (operation == 'd')
                {
                    //tell user what operation they choose
                    Console.WriteLine("diviison");

                    //calls the division method
                    double result = divide(firstNumber, secondNumber);

                    //output the 2 numbers that the user inputs and the asnwer
                    Console.WriteLine("the result of the division of {0} by {1} is {2} ", firstNumber, secondNumber, result);
                    Console.ReadLine();

                }
                //runs through this statement if user wants to multiply
                else if (operation == 'm')
                {
                    //calls the multiply method
                    double product = multiply(firstNumber, secondNumber);

                    //output the 2 numbers that the user inputs and the asnwer
                    Console.WriteLine("the result of the multiply of {0}, by {1} is {2} ", firstNumber, secondNumber, product);
                    Console.ReadLine();

                }



            }
            }
    }




            
                









    

