//Abinash Kumanan
//0671007
//This progrm will allow the user to hold up to 10 people in a plane. They will have to ask for the customers name and assign them a seat using arrays.\n
//The user can cancel the customers seat number, print out how many seat numbers are taken or quit the program.\n
//This program will only allow for 10 people (max) to be assigned seats and anything past that cannot be allowed 

using System;
namespace assignment4
{
    public class Assigment44
    {
        static void Main(string[] args)
        {
            //Assigning how many seats they are avalible
            string[] seat = new string[10];

            // initialize seat with null
            for (int i = 0; i < 10; i++)
            {
                //i woulld equal null
                seat[i] = null;
            }

            //varible for user input
            char input = ' ';

            //do while loop
            do
            {
            //User chooses where if they want to book,print and cancel customers seats or if they want to quit the program
            Console.Write("Enter letter B or b if you would like book a seat \n" +
                          "Enter letter C or c if you would like to cancel a booked seat \n" +
                          "Enter letter P or p if you would like to print out how many seats are booked \n" +
                          "Enter letter Q or q if you would like to quit the program \n");

            //Converts user input into a doule 
            input = Convert.ToChar(Console.ReadLine());

                //Goes through this switch stament because each letter has different cases to them
                switch (input)
                {
                    //If the user chooses to book a seat
                    case 'b':
                    case 'B':
                        
                            //calls the booking method
                            Booking(seat);
                            break;
                        
                    //If the users chooses to cancel a seat
                    case 'c':
                    case 'C':
                        
                            //calls the cancel method
                            Cancel(seat);
                            break;
                        
                    //if the user wants to see how many seats are booked
                    case 'p':
                    case 'P':
                        
                            //Calls the print seat method
                            PrintSeats(seat);
                            break;
                        
                    //If the user wants to quit the program
                    case 'q':
                    case 'Q':
                        
                            //Prints out quit message 
                            Console.WriteLine("you have quit the program");
                            return;

                        default:
                        //Prints our error message if the user enters a diffrent letter
                        Console.WriteLine("Error please enter a valid letter");
                        break;
                }
                

              //Will keep running through this loop unitl the user chooses to quit the program
            } while (char.ToUpper(input) != 'Q');


        }

        // return first empty seat index
        public static int FindEmptySeat(string[] SeatAssign)
        {
            //Initialize emp seat to negitave 1 if the seats get full
            int empSeat = -1;

            //This loop will search a empty seat to asign to the customer 
            for (int i = 0; i < SeatAssign.Length; i++)
            {
                //Go through this statment when it find a empmty seat to assign to the customer
                if (SeatAssign[i] == null)
                {
                    //empseat will equal to i
                    empSeat = i;
                    break;
                }
            }
            //retun what empseat will return i 
            return empSeat;
        }
        //This method will search what person is assigned to what seat
        public static int FindCustomerSeat(string[] SeatAssign, string cName)
        {
            //Assign findSeat to negitve 1 if the customers name is not on the list 
            int findSeat = -1;

            //This loop will search if a customer is already assigned a seat
            for (int i = 0; i < SeatAssign.Length; i++)
            {
                
                //If the seat is found by the number and custmoers name it wil go through this statment
                if (SeatAssign[i] != null && SeatAssign[i] == cName)
                {
                    //findseat will equal i 
                    findSeat = i;
                    break;
                }
            }
            //return find seats value
            return findSeat;
        }
        
        //This method will allow the user to book a seat to a customer
        public static void Booking(string[] SeatAssign)
        {
            //Varible name for assigning customer name
            string cusName;

            //Asks user to input customer name
            Console.Write("Enter customer name (First and Last): ");
            cusName = Convert.ToString(Console.ReadLine());


            //if custmoer is already assigned a seat 
            if (FindCustomerSeat(SeatAssign, cusName) > -1)
            {
                //Message if customers name is already booked
                Console.WriteLine(" {0}  already booked seat number {1}", cusName,(FindCustomerSeat(SeatAssign, cusName) + 1));

            }

            //It will book a seat for the customer
            else
            {
                //calls the findemptyseat method
                int bookingSeatNum = FindEmptySeat(SeatAssign);

                // if all seats are booked
                if (bookingSeatNum == -1)
                {
                    //Pritns out sorry message
                    Console.WriteLine("\nSorry {0} All seats are booked", cusName);
                }
                else
                {

                    //assign seat to customers name 
                    SeatAssign[bookingSeatNum] = cusName;

                    //Prints out seat number and customers name 
                    Console.WriteLine( "seat {0} is booked for {1} ",bookingSeatNum+1, cusName);
                }
            }

        }

        //If the user decides to cancel the customers seat
        public static void Cancel(string[] SeatAssign)
        {
            //Varible for customer name
            string cusName1;
            //Asks user customers name
            Console.Write("Enter customer name: ");
            cusName1 = Convert.ToString(Console.ReadLine());
            

            
            //Calls FindCustomerSeat method to find the customers seat and their name
            int cusFound = FindCustomerSeat(SeatAssign, cusName1);
          
            // if customer found
            if (cusFound > -1)
            {
                
                //It will delete customer from its seat
                Console.WriteLine(" {0} seat {1} has been cancled " ,SeatAssign[cusFound],(cusFound + 1));
                SeatAssign[cusFound] = null;
            }

            // customer not found
            else
            {
                //Cannot find customer message
                Console.WriteLine("\nSorry , {0} has not booked a seat ", cusName1);
            }
        }
        //Prints out how many seats are taken
        public static void PrintSeats(string[] SeatAssign)
        {
            //intialize seatLen
            int seatLen = SeatAssign.Length;
            //initlize seatIndex to 0
            int seatIndex = 0;

            //searches for the seat numbers taken
            for (int i = 0; i < seatLen; i++)
            {
                
                //if seat is not equal to null 
                if (SeatAssign[i] != null)
                {
                    //It will print out customers name with their seat number
                    Console.WriteLine(" {0} has booked seat number {1} ", SeatAssign[i],(seatIndex + 1));
                    seatIndex++;
                }
            }
        }



















    }
}
