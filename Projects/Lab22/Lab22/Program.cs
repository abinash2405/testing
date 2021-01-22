//Abinash Kumanan
//0671007
//This program will input 10 student marks and will only calculate the average of the passing grade.
//The passing range is between 60 and 100 and students.
//Students that have a mark below 60 and greater 100 are not in the passing range
//I used 4 variables:

//int grade;
//varible that collects all the students grade

//double average = 0;
//varible that caculates the class average

//int sumGrade = 0;
//Varible that collects the sum of the grade

//int studentPass = 0;
// Counts how many students have passed
using System;

{
    class MainClass
    {

        public static void Main()
        {
            //varible that collects all the students grade
            int grade;
            //varible that caculates the class average
            double average = 0;
            //Varible that collects the sum of the grade
            int sumGrade = 0;
            // Counts how many students have passed
            int studentPass = 0;


            // inputs a for loop that will ionly allow the profeessors to input 10 marks.
            for (int i = 0; i < 10; i++)
            {
                //Enter students mark
                Console.WriteLine("PLease input students mark:");

                //Coverts grade to an integer
                grade = Convert.ToInt32(Console.ReadLine());

                //if statemnts that will see if the mark is the passing range
                if (grade >= 60 && grade <= 100)
                {
                    //if grade passes it will clauclated the sum of grades passed
                    sumGrade +=grade;
                    //as each students pass this varible will increment by one
                    studentPass++;

                }
                //If student is not in the passing range
                else
                {
                    //Failure message
                    Console.WriteLine("Student did not in the passing range");

                }

               }

            // Calulates thr average(sume/count)
            average = sumGrade /studentPass;
            //Outputs the average
            Console.WriteLine("the class average is: {0}",average);
            Console.ReadLine();


        }
    }
}






















