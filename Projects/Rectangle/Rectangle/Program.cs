using System;

namespace Rectangle
{
    class Mainclass
    {
        public static void Main()
        {
            Rectangle rec = new Rectangle(10, 5);
            double area = rec.getArea();

            System.Console.WriteLine("The area is {0}", rec.getArea());
            System.Console.WriteLine("The length is {0} ", getLength());


            System.Console.ReadLine();







        }
    }


    public class Rectangle
    {
        private double length;
        private double width;

        public Rectangle(double length, double width)
        {

            this.length = length;
            this.width = width;


        }
        public double getArea()
        {

            return length * width;



        }

        public double getLength()
        {


            return length;
        }




    }
    //Public double Rectangle{

    //}

    //get
    //{

    //return length
//}

    //set{
    //

    //string[] stringArr = new string[5];
    //Rectangle[] recArr = new Rectangle [5];




}






