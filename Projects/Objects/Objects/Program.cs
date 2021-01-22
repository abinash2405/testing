using System;

namespace Objects
{
    class Laptops
    {
        string brand;
        string modelNumber;
        string Os;
        int Ram;
        double screenSize;

        public void  Start()
        {

            System.Console.WriteLine("The laptop is truning on please wait");
            System.Console.ReadLine();
        }

        public void Shutdown()
        {
            System.Console.WriteLine("The laptops are now shutting down");
            System.Console.ReadLine();



        }
        public Laptops (string brand, string modelNumber, String OS, string Ram, double screenSize)

        {

            this.brand = brand;
            this.modelNumber = modelNumber;




        }

        public Laptops()
        {


        }





        
    }
}
