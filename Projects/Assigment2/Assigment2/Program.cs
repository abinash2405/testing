//Abinash Kumanan
//0671007
//This program will allow the user to input peoples salary with university degrees, college diplomas, and high school diplomas.
//Then it will calulate the average slalry of people that have each level of education
//It will not accpet any negitave numbers
using System;

namespace Assigment2
{
    class MainClass
    {
        public static void Main()
        {

            char edType = ' ';

            //variable to find the average salary for university students
            double avgU = 0;
            //variable to find the average salary for college students
            double avgC =0;
            //variable to find the average salary for highschool students
            double avgH = 0; 

            //varible that finds the total amount of salaries for university students
            double totalU = 0;
            //varible that finds how much salaries that were inputed for university students
            int SalarycountU = 0;

            //varible that finds the total amount of salaries for college students
            double totalC = 0;
            //varible that finds how much salaries that were inputed for college students
            int SalarycountC = 0;
            
            //varible that finds the total amount of salaries for highschool students
            double totalH = 0;
            //varible that finds how much salaries that were inputed for highschool students
            int SalarycountH = 0;

            //varible when the user inputs the salaries
            double salary;




            //Runs through this loop if the user doesnt input Q
            while (char.ToUpper(edType) != 'Q')
            {
                //Asks the user what level of education the person has inorder to input their salary
                Console.WriteLine("Please indicate your level of education, 'U' or 'u' for university degrees, 'C' or 'c' for college diplomas,'H' or 'h' for high school, " +
                "and if you want to quit, enter 'Q' or 'q': ");
              //Converts input into a char
              edType = Convert.ToChar(Console.ReadLine());

                //Runs through this if statement if the user inputs Q
                if (char.ToUpper(edType) == 'Q')
                {
                    //the program gets out of this loop and if statment and outputs the averages
                    break;
                }


                //Asks the user to input each persons salary 
                Console.WriteLine("Please enter the persons salary");

                //Converts the user inout into a double
                salary = Convert.ToDouble(Console.ReadLine());

                //Runs through this if statment if salary is greater then 0
                if (salary > 0)
                {
                     //Runs through this switch statement because their are diffrent cases depending on what the user inputs
                     switch (edType)
                    {
                        //Runs through this case if the user inputs u or U

                        case 'U':
                        case 'u':
                            //calculates the total salary for every person that attended university
                            totalU = totalU + salary;
                            //calcualtes how many slalares were inputed if they attened university
                            SalarycountU = SalarycountU + 1;
                            //calculates the average of the salaries
                            avgU = totalU / SalarycountU;
                          break;

                        //Runs through this case if the user inputs c or C
                        case 'C':
                        case 'c':
                            //calculates the total salary for every person that attended college
                            totalC = totalC + salary;
                            //calcualtes how many slalares were inputed if they attened college
                            SalarycountC = SalarycountC + 1;
                            //calculates the average of the salaries
                            avgC = totalC / SalarycountC;
                            break;
                        //Runs through this case if the user inputs h or H
                        case 'H':
                        case 'h':
                            //calculates the total salary for every person that attended highschool
                            totalH = totalH + salary;
                            //calcualtes how many slalares were inputed if they attened highschool
                            SalarycountH = SalarycountH+ 1;
                            //calculates the average of the salaries
                            avgH = totalH / SalarycountH;
                            break;
                        default:
                            break;

                    }
                    //end if switch case
                }
                //if the salary is less than zero
                else if(salary==0)
                {
                    //inputs error message
                    Console.WriteLine("Error cannot input zero please try again");
                }
                else
                {
                    //inputs error message
                    Console.WriteLine("Error negitave number please try again");
                }
                //end of if statment 

                }
            //end of while loop
            
                //Outputs the average for university students
               Console.WriteLine("Total Slalry of University Students is {0}, " +
                                " Number of People that attened University is {1}," +
                                " The average salary for university students {2}",totalU,SalarycountU,avgU );
               //Outputs the average for college students
               Console.WriteLine("Total Slalry of College Students is {0}, " +
                                 " Number of People that attened College is {1}," +
                                 " The average salary for College students {2}", totalC, SalarycountC, avgC);
               //Outputs the average for college students
               Console.WriteLine("Total Slalry of High school Students is {0}, " +
                                 " Number of People that attened High school is {1}," +
                                 " The average salary for High school students {2}", totalH, SalarycountH, avgH);









        }


    }
}








































