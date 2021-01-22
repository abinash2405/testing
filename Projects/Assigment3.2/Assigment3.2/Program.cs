//0671007
//Abinash Kumanan
//November,20,2019
//This program will help balance the users bank account, their are for methods are the main method, the get amount method, the withdrawl method and the print method
//This program will prevetn users from entering negitave numbers, getting a negitave balance, or just not entering the input the program asks to enter
//The balance and your amount will start at zero
//All the serivce fees and bonus are included in the program when the user deposits or withdrawl
//At the end of the program it will print your final balance after all the deposits and withdrawl you have made

using System;

namespace Assigment3
{
    class MainClass
    {
        //Main Mthod
        public static void Main()
        {
            //varible for when the user inputs thier function
            char input = ' ';

            //varible to initlize balance to zero and amount
            double balance = 0;
            //Varible to initalize to amount to zero
            double amount = 0;
            //Welcome Message
            Console.WriteLine("Welcome, this program will help balance your bank account");

            //goes through this do while loop until user wants to quit            
            do {

                //asks the user whether they want to deposit,withdrawl,print or quit
                Console.WriteLine("Press w or W for withdrawal money , d or D for deposit money , p or P for print out your balance , and q or Q for quit to quit the program : ");
                //converts input to a char
                input = Convert.ToChar(Console.ReadLine());


                //Goes through this switch stament because each letter has different cases to them
                switch (input)
                {
                    //if the user chooes w or withdrawl 
                    case 'w':
                    case 'W':
                        //Get amount method is called
                        amount = GetAmount();
                        //Wihdrawl method is called
                        Withdrawal(amount, ref balance);
                        break;
                    //if the user chooses d or deposit
                    case 'd':
                    case 'D':
                        //get amount method is called
                        amount = GetAmount();
                        //Deposi method is called
                        Deposit(amount, ref balance);
                        break;

                    //If the user chooses p or print
                    case 'p':
                    case 'P':
                        //Print method is called
                        Print(balance);
                        break;
                    //If the users wants to quit the program
                    case 'q':
                    case 'Q':
                        Console.WriteLine("You have quit the program");
                        return;
                    default:
                        //If the user inputs another letter instead
                        Console.WriteLine("Please enter a valid option given to you");
                        break;
                }
                //Keep running through this loop unitl user inputs q or Q
            } while (char.ToUpper(input) != 'Q');
        }

        //Runs through this method when the user is asked to enter the amount
        public static double GetAmount()
        {
            //Varible name for amount inputed
            double amount1;
            //Asks the user how much would they like to deposit or withdrawl
            Console.WriteLine("Please enter the amount you would like to deposit or withdrawl");
            //Converts amount to an double 
            amount1 = Convert.ToDouble(Console.ReadLine());

            //To validate the amount is an postive number it will run through this if statment 
            if (amount1 > 0)
            {
                //If amount is postive it will retuun amount
                return amount1;
            }
            //Runs through this else statment if the amount is negitave
            else
            {
                //Error message is printed 
                Console.WriteLine("Erorr you have inputed a negitave number please try again");
                Console.ReadLine();
            }

            //return type for the method
            return amount1;



        }
        //Runs through this statment if the user wants to an withdrawal
        public static void Withdrawal(double amount, ref double balance)
        {
            // if the user has insufficien blanace ans sees if the amount is valid to withdrawl including the serive fee
            if (balance < (amount + 1.5))
            {

                //Prints out if the amount asked to withdrawl higher than your remaining balaance
                Console.WriteLine("You have insufficient balance in your account please enter a lower amount");
                Console.WriteLine("Heres your balance remaining {0} ", balance);
                Console.ReadLine();
            }
            // else deduct the amount from the balance along with service charges
            else
            {
                //Calucation to decut amountf from balance plus the serive fee
                balance -= amount + 1.5;
                //Message for the ne balance
                Console.WriteLine("Heres the amount you withdrawl {0} and your new balance {1}",amount, balance);
                Console.ReadLine();
            }
        }

        //Goes through this method if the user chooses to deposit
        public static void Deposit(double amount, ref double balance)
        {
            if (amount >= 2000)
            {
                //If amount is geater than 2000 they would get the bonus 
                Console.WriteLine("Since you amount deposit was equal or greater than 2000 you get a 1 percent bonus");
                //Calualcations to get the 1 percent bonus
                balance += amount * 1.01;
                //Tells the user their new amount with the bonus 
                //Prints out balance
                 Console.WriteLine("The amount you deposited was {0} and your balance is {1} ", amount, balance);
                Console.ReadLine();
            }
            else
            {
                if (amount < 0)
                {

                }
                else
                {
                    //adds amount to the balance
                    balance += amount;
                    //Prints this message if the amount was less than 2000
                    Console.WriteLine("The amount you deposited was {0} and your balance is {1} ", amount, balance);
                    Console.ReadLine();
                }
                }

        }
        //If the user chooses to to see their balace will run through this Method
        public static void Print(double balance)
        {
            //Prints out message for your final balance
            Console.WriteLine("Your balance remaing in your account is $" + balance);
            Console.ReadLine();
        }
    }
}
    

    
