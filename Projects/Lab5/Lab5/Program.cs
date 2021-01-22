//Abinash Kumanan
//0671007
//This program will create an object and have protperies to define that object
//Input each property given for each shoe
//Each shoe that was made has to go into an array and output how many elements were inputed.

using System;

namespace Lab5
{
    //object declatration 
    public class Shoes
    {
        //Properties that I made for my object
        double shoeSize;
        string color;
        string typeShoe;
        string material;
        string brand;


        //Outputs each property
        public static void Main(string[] args)
        {

            //Properties for Nike Shoes
            Shoes Nike = new Shoes();
            Nike.brand = "Nike";
            Nike.color = "Black";
            Nike.typeShoe = "Basketball";
            Nike.shoeSize = 12;

            //Properties For Jordan Shoes
            Shoes Jordan = new Shoes();
            Jordan.brand = "Jordan";
            Jordan.color = "Red";
            Jordan.typeShoe = "Casual";
            Jordan.shoeSize = 10;

            //Properties for Addidas Shoes
            Shoes Addidas = new Shoes();
            Addidas.brand = "Addidas";
            Addidas.color = "Blue";
            Addidas.typeShoe = "Soccer";
            Addidas.shoeSize = 8;

            //inputing arry of each shoes
            Shoes[] shoesArray = new Shoes[3];
            shoesArray[0] = Nike;
            shoesArray[1] = Jordan;
            shoesArray[2] = Addidas;

           
            //output the elements for are inputed in the array
            System.Console.WriteLine("The length of the array is {0}", shoesArray.Length);
            System.Console.ReadLine();









        }
    }
        




        }



    


