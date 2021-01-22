


    public class Shoes
        {
            double shoeSize;
            string color;
            string typeShoe;
            string material;
            string brand;


        public static void Main (double shoeSize,string color,string typeShoe, string material, string brand)
            {
            Shoes Nike = new Shoes();
            Nike.brand = "Nike";
            Nike.color = "Black";
            Nike.typeShoe = "Basketball";
            Nike.shoeSize = 12;

            Shoes Jordan = new Shoes();
            Jordan.brand = "Jordan";
            Jordan.color = "Red";
            Jordan.typeShoe = "Casual";
            Jordan.shoeSize = 10;

            Shoes Addidas = new Shoes();
            Addidas.brand = "Addidas";
            Addidas.color = "Blue";
            Addidas.typeShoe = "Soccer";
            Addidas.shoeSize = 8;

            Shoes[] shoesArray = new Shoes[3];
            shoesArray[0] = Nike;
            shoesArray[1] = Jordan;
            shoesArray[2] = Addidas;

            System.Console.WriteLine("The length of the array is {0}", shoesArray.Length);









        }

        
       
    }
    

