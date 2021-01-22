// create project name Customer

using System;

namespace Customer
{
    class Program
    {

        // print all seats

        public static void PrintSeats(string[] SeatAssign)
        {
            int len = SeatAssign.Length;
            int index = 0;

            for (int i = 0; i < len; i++)
            {
                // if seat not null

                if (SeatAssign[i] != null)
                {
                    Console.WriteLine((index + 1) + ") Seat number " + (i + 1) + " and Holder number " + SeatAssign[i]);
                    index++;
                }
            }
        }


        // cancel thye seat
        public static void Cancel(string[] SeatAssign)
        {
            string name;
            Console.Write("Enter customer name : ");

            // user input

            name = Console.ReadLine();


            // get customer index

            int index = FindCustomerSeat(SeatAssign, name);

            // if customer found
            if (index > -1)
            {
                // delete customer

                Console.WriteLine("\nCustomer name " + SeatAssign[index] + " is cancelled seta number " + (index + 1));
                SeatAssign[index] = null;
            }

            // customer not found
            else
            {
                Console.WriteLine("\nSorry , Customer name " + name + " not found");
            }
        }

        // book seat

        public static void Booking(string[] SeatAssign)
        {
            string cusName;

            Console.Write("Enter customer name : ");

            // user input

            cusName = Convert.ToString(Console.ReadLine());


            // customer found
            if (FindCustomerSeat(SeatAssign,cusName) > -1)
            {
                Console.WriteLine("\nCustomer " + cusName + " already booked seat number " + (FindCustomerSeat(SeatAssign, cusName) +1  ));
            }

            // customer found
            else
            {
                int bookingSeatID = FindEmptySeat(SeatAssign);

                // if all seats are booked

                if (bookingSeatID == -1)
                {
                    Console.WriteLine("\nSorry ," + cusName + " All seats are booked .");
                }
                else
                {

                    // assign seat
                    SeatAssign[bookingSeatID] = cusName;
                    Console.WriteLine("\nSeat number " + (bookingSeatID + 1) + " booked for for " + cusName);
                }
            }

        }


        // get customer seat number

        public static int FindCustomerSeat(string[] SeatAssign, string cName)
        {
            int ret = -1;

            for (int i = 0; i < SeatAssign.Length; i++)
            {
                // if seat found using name

                if (SeatAssign[i] != null && SeatAssign[i] == cName)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }

        // return first empty seat index

        public static int FindEmptySeat(string[] SeatAssign)
        {
            int ret = -1;

            for (int i = 0; i < SeatAssign.Length; i++)
            {
                if (SeatAssign[i] == null)
                {
                    ret = i;
                    break;
                }
            }

            return ret;
        }


        static void hi(string[] args)
        {
            string[] seat = new string[10];

            // initialize seat with null

            for (int i = 0; i < 10; i++)
            {
                seat[i] = null;
            }

            char input = ' ';
            // loop
            do
            {

               

                Console.Write("Enter Command B if you would like book a seat \n" +
                               "Enter Command C if you would like to cancel a booked seat \n" +
                              "Enter Command P if you would like to print out how many seats are booked \n" +
                              "Enter Command Q if you would like to quit the program \n");

                input = Convert.ToChar(Console.ReadLine());

                // user command
                switch (input)
                {
                    case 'b':
                    case 'B':
                        {
                            Booking(seat);
                            break;
                        }
                    case 'c':
                    case 'C':
                        {
                            Cancel(seat);
                            break;
                        }
                    case 'p':
                    case 'P':
                        {
                            PrintSeats(seat);
                            break;
                        }
                    case 'q':
                    case 'Q':
                        {
                            Console.WriteLine("you have quit the program");
                            break;
                        }
                }


            } while (char.ToUpper(input) != 'Q');


        }
    }
}