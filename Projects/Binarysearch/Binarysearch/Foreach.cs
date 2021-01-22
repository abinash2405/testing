using System;
namespace Binarysearch
{
    public class Foreach
    {
        public Foreach()
        {

            int[] numbers = { 10, 20, 30, 40 };

            for (int i = 0;, i <= numbers.Length; i++){

                numbers[i] = numbers[i] + 10;
               Console.WriteLine(numbers[i]);


            }
            Console.ReadLine();

            foreach(int element in numbers)
            {
                numbers[i] = numbers[i] + 10;
               Console.WriteLine(numbers[i]);


            }







        }
    }
}
