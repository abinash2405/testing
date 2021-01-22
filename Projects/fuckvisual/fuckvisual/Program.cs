//Abinash Kumanan
//0671007
//This program will get the input on how many donuts the user inputs
//it will add the flat fee and give you a total price with tax
//if the users inputs 12 or more donuts they will save hst
//the user cannot enter a negitave number of donuts
//the final output for this prgram will be your last name how many donuts you bought and the totoal

using System;
namespace Assigment1
{
    public class Assigment1
    {
        public static void Main()
        {
            //Last name varible
            string lastName;
           
            //varible for amount of donuts purchased
            int donutPurchased;

            //constant value of tax
            const double Hst = 0.13;

            //adds the flat fee
            double addFee;

            //flate fee value
            const double flatFee = 0.25;

            //Value before tax
            double beforeTax;

            //Value after tax
            double afterTax;

            //Total price after tax
            double total = 0;


            //check wheter the input is false
            bool check = false;
  
            //This do while loop will validate the amount of donuts purchased is valid or not
            do
            {

                //user inputs how many donuts they will buy
                Console.WriteLine("how many donuts would you like to buy?");

                //convets donutPurchased to a int
                donutPurchased = Convert.ToInt32(Console.ReadLine());

                // boolen check weather true or false
                check = true;

                // donutPurchased is a negitave number it will run through this statement
                if (donutPurchased < 0)
                {
                    //if its false it will output the next line
                    check = false;

                    //it well tell the user you cannot enter a negitave number
                    Console.WriteLine("You cannot input a negitave number");
                   

                }

                //run through this while loop until the staement becomes true
            }   while (check == false);

                //keep console open
                Console.ReadLine();


            //this do while loop wil; not allow to have an empty string or last name
            do
            {
                //users inputs their last name
                Console.WriteLine("Please input your last name");

                //accepting input
                lastName = Console.ReadLine();

                //boolean check equal to true 
                check = true;

                //if the string is empty then we set the boolean equal to false reapiting the false statement
                if (string.IsNullOrEmpty(lastName))
                {

                    //runs through this statment if the string is empty
                    check = false;
                    //telling the user what they did wrong
                    Console.WriteLine("You cannot input empty lastname");
                }

              //this staement will keep running through this while loop unitl the statment become true
            } while (check == false);


            //Console.ReadLine() to keep the console open.
            Console.ReadLine();


            
           

             //If the users purchases 7 or less than 7 donuts it will run trough this if statment
            if (donutPurchased <= 7 && donutPurchased >0 )
            {
                //donut price when you buy 7 or less donuts
                double donutPrice = 1.00;

                //Calculates the value of the price for the amount of donuts your buying
                beforeTax = donutPurchased * donutPrice;

                //adds the flat fee to the price
                addFee = beforeTax += flatFee;

                //gets the price after the fees and multiplys it with Hst
                afterTax = beforeTax * Hst;

                //add Hst amount with Flat fee price
                total = beforeTax + afterTax;

               


            }

            //If the users purchases between 8 and 11 donuts it will run trough is if statment
            else if (donutPurchased >= 8 && donutPurchased < 12)

            {
                //donut price when you buy between 8 and 11 donuts
                double donutPrice = 0.90;


                //If user buys betwewen 12 and 14 donuts
                if (donutPurchased >= 12 && donutPurchased < 15)

                {

                   
                    //Since your buying more than 12 donuts you save on HST
                    Console.WriteLine("You save Hst becasue you have bought 12 donuts or more");

                    //Calculates the value of the price for the amount of donuts your buying
                    beforeTax = donutPurchased * 0.90;

                    //adds the flat fee to the price
                    addFee = beforeTax += flatFee;

                    //Total price
                    total = addFee;
                }

            
                //Calculates the value of the price for the amount of donuts your buying
                beforeTax = donutPurchased * donutPrice;

                //adds the flat fee to the price
                addFee = beforeTax += flatFee;

                //Price is caluclated with tax
                afterTax = beforeTax * Hst;

                //add Hst amount with Flat fee price
                total = beforeTax + afterTax;


            }  

            //If the user buys if or more donuts
            else if (donutPurchased >= 15)
            {
                //Since your buying more than 12 donuts you save on HST
                Console.WriteLine("You save Hst because you have bought more than 12 donuts");

                //The price of donuts when you buy 15 or more
                double donutPrice = 0.75;

                //Calculates the value of the price for the amount of donuts your buying
                beforeTax = donutPurchased * donutPrice;

                //adds the flat fee to the price
                addFee = beforeTax += flatFee;

                //Total price
                total = addFee;



            }

            //Outputs your last name the amount of donuts you bought and the total price for it
            Console.WriteLine("{0} You have bought {1} donuts for $ {2}", lastName, donutPurchased, total);
            Console.ReadLine();







        }


    }

}
