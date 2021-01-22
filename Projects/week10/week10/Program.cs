using System;

namespace GetSet
{
    public class Console
    {
        public static void Main()
        {
            Car Audi = new Car();

            Audi.CarMake = "kia";
            Audi.CarYear = 2001;


            Car Audi = new Car("Audi", 2020);

            Car Honda = new Car("honda", 2019);

            Audi.Message();




        }

        public class Car
        {

            private string carMake;
            private int carYear;


            public Car(string carMake, int carYear)
            {

                this.carMake = CarMake;
                this.carYear = carYear;

            }





            public Car (int carYear, string carMake)
            {

                if (carYear < 1900)
                {

                    System.Console.WriteLine("Error no car existed back then");
                }
                this.carYear = carYear;
                this.carMake = carMake;


            }
            public Car()
            {

            }







            public String CarMake
            {
                get
                {

                    return carMake;


                }
                set
                {
                    if(carMake== "kia")
                    {

                        CarMake = "You cannot input kia";
                    }
                    else
                    {
                        carMake = value;

                    }



                }

              }
            public int CarYear
            {

                get
                {

                    return carYear;




                }
                set
                {
                    carYear = value;







                }









            }




            public void Message()
            {

                System.Console.WriteLine("The car make is {0}, the car year {1} ", carMake,carYear);
                System.Console.ReadLine();


            }



        }









    }
}
