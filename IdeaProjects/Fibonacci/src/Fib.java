/* Abinash Kumanan
0671007
Febuary,7,2021
Assignment 1 COIS 2240H

This program will allow the user to input a number to print out the fibnacci sequnce based on the user input.
It will print out the sequnce using the recursive method and the iterative method.
It will also tell you how long it took to output the number after the user input in nanoseconds.
*/


import java.util.concurrent.TimeUnit;
import java.util.*;


public class Fib {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        //Start time for recursive output
        long startTime;

        //End time for recursive output
        long endTime;

        //Start time for iterative output
        long startTime1;

        //End time for iterative output
        long endTime1;

        //Initalize n
        int n =0;

        //Goes through this loop unitl user inputs a positive number
        do {

            //Asks user to input
            System.out.println("Hello, please enter a Number");

            //User input is n
            n = sc.nextInt();

        //If user inputs a higher number than 0 it will exit out this loop
        }while (n<=0);


        //Starts time for recursive function
        startTime= System.nanoTime();

        //Output for Recursive Method
        System.out.println ("Recursive output is: ");


        //Goes in for loop to print the sequnce to the nth number
        for (int i = 0; i < n; i++) {

            //Calls recursive method
            System.out.print( recursive(i) + " ");

        }

        //Ends time for recurisve output
        endTime = System.nanoTime();
        System.out.println();

        //Prints out time it took to print out the sequnce recursively in nanoseconds
        System.out.println("The elasped time in nanseconds is is:"+ (endTime - startTime));


        //Prints out the time in milliseconds
        System.out.println ("The elasped time in milliseconds is:" + (endTime - startTime)/1000000);
        System.out.println();

        //Starts time for iterative functiom
        startTime1= System.nanoTime();

        //Iterative Ouput
        System.out.println("Iterative output is: ");

        //Goes in for loop to print the sequnce to the nth numbervhvb
        for (int i = 0; i <n ; i++){

            //Calls iterative method
            System.out.print ( iterative(i) + " ");
        }
        //Ends time for iterative output
        endTime1 = System.nanoTime();
        System.out.println();

        //Prints out time to took to print out the sequnce iteratively in nanoseconds
        System.out.println("The elasped time in nanoseconds is:"+ (endTime1 - startTime1));

        //Prints out time it took to print out in milliseconds
        System.out.println("The elasped time in milliseconds is:"+ (endTime1 -startTime1)/1000000);

    }

    //Recursive method
    static int recursive (int n) {

        //If user inputs 1 it would return n
        if (n <= 1){
            return n;
        }

        //If user inputs higher than 1 than it will go through this fucntion to ouput the fibonacci series recursively.
        else {
            //It will keep calling this function until n-1=0 and n-2=1
            return recursive(n - 1) + recursive(n - 2);
        }


    }
    //Method for iterative function
    public static int iterative(int n){

            //Intilize previousNum to zero
            int previousNum = 0;

            //Intilize currentNum to 1
            int currentNum = 1;

            //goes through the for loop to calcuate the nth number based on user input
            for (int i = 0; i < n; i++) {

                //Initilize nextNum to equal previousNum
                int nextNum = previousNum;

                //Switch previousNum to equal currentNum
                previousNum = currentNum;

                //To get the new value of currentNum we add nextNum and currentNum
                currentNum = nextNum + currentNum;
            }

            //Return the value previousNum back into the iterative for loop
            return previousNum;

    }
}











