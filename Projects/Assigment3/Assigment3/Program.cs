using System;

namespace Assigment3
{
    class MainClass
    {
        public static void Main()
        {
            //varible for when the user inputs thier function
            char input = ' ';

			//varible to initlize balance to zero
			double balance = 0.0;
            

            //goes through thid do while loop
            do
            {
                //asks the user whether they want to deposit,withdrawl,print or quit
                Console.WriteLine("deposit 'd' or withdrawl 'w' , print 'p' or 'P' , quit 'q' or 'Q'");
                //converts input to a char
                input = Convert.ToChar(Console.ReadLine());

                //Goes through this switch stament because each letter has different cases to them
                switch (input)
                {
                    //if the user chooses d or deposit
                    case 'D':
                    case 'd':
                        //call this getAmount method
                        GetAmount();
                        Deposit(amount, ref balance);
                        break;

                    //if the user chooes w or withdrawl 
                    case 'W':
                    case 'w':
                        //Calls the getAmount method
                        GetAmount();
                        break;

                    //If the user chooses p or print
                    case 'P':
                    case 'p':

                        //Calls this print stament which should print the balance amount
                        Print(balance);
                        break;
                    default:
                        break;

                }
                //Keep running through this loop unitl user inputs q or Q
            } while (char.ToUpper(input) != 'Q');
        }
            public static double GetAmount()
            {
                double amount;
                // this loop is executed until the user enters a non-negative value
                while (true)
                {
                    Console.WriteLine("Enter the amount ( >= 0) : ");
                    amount = double.Parse(Console.ReadLine());
                    if (amount >= 0.0)
                        break;
                    Console.WriteLine("Invalid value entered.....pls try again!!");
                }
                // return amount
                return amount;
            }
        
        
        //Goes through this method if the user chooses to deposit
         public static void Deposit(double amount, ref double balance) 
        {
            //varible names for the amount
            double amount1;
            double amount2;
           
            //If the amount is greater than 2000 they user gets a 1 percent bonus and to validate that it will run through this if statment 
            if (amount >= 2000)
            {
                //If amount is geater than 2000 they would get the bonus 
                Console.WriteLine("Since you amount deposit was equal or greater than 2000 you get a 1 percent bonus");
                //Calualcations to get the 1 percent bonus
                amount1 = amount/100 ;
                amount2 = amount + amount1;
               //Tells the user their new amount with the bonus 
                Console.WriteLine("Your new amount is {0}", amount2);
                //Adds the amount to the balance
                balance +=  amount2;
                //Prints out balance
                Console.WriteLine("your balance is {0}",balance);
            }
            else
            {
                //adds amount to the balance
                balance += amount;
               //Prints this message if the amount was less than 2000
                Console.WriteLine("The amount you deposited was {0} and your balance is {1} ", amount, balance);
                }

       }
      //Runs through this statment if the user wants to an withdrawal
      public static void Withdrawal(double amount, ref double balance)
        {
            //Runs through this if stament to see if balance is not zero so user can withdrawl from their account
            if(balance > 0)
            {
                //If balance is greater than zero the user can withdrawl from their acount and get charged a 1.13 dollar service fee
                balance -= amount - 1.13; 


            }else
            {
                //If balance is zero or negitave the error message will show
                Console.WriteLine("Error cannot withdawl when balance is zero");

            }

            }
        //If the user chooses to to see their final balace will run through this Mehod
        public static void Print(double balance)
        {

            //Prints out your final balance
            Console.WriteLine("Your balance is {0}", balance);
        }



}
}








