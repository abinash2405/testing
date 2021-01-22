using System;
public static class ComputeAverageFor
{
    public static void Main()
    {
        int numMarks, mark, total = 0;
        double averageMark;
        Console.Write("Enter the number of marks (+ve) => ");
        numMarks = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < numMarks; ++i)
        {
            Console.Write("Enter a mark => ");


            mark = Convert.ToInt32(Console.ReadLine());
            total = total + mark;
        }

    }
}
