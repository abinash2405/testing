import java.util.concurrent.TimeUnit;
import java.util.*;


public class Fib {

    public static void main(String[] args) {

        Scanner sc = new Scanner(System.in);

        long startTime;
        long endTime;
        long startTime1;
        long endTime1;

        System.out.println("Enter a Number");
        int n = sc.nextInt();
        startTime= System.nanoTime();



        System.out.println ("Recursive: ");
        for (int i = 0; i < n; i++) {

            System.out.print( recursive(i) + " ");

        }
        endTime = System.nanoTime();
        System.out.println("The elasped time is:"+ (endTime - startTime));


        System.out.println();
        startTime1= System.nanoTime();
        System.out.println("Iterative: ");
        for (int i = 0; i <n ; i++){

            System.out.print ( iterative(i) + " ");
        }
        endTime1 = System.nanoTime();
        System.out.println("The elasped time is:"+ (endTime1 - startTime1));





    }


    static int recursive (int n) {

        if (n == 0)
            return 0;
        else if (n<=1){

            return n;
        }


        else {

            return recursive(n - 1) + recursive(n - 2);
        }


    }

    public static int iterative(int n) {
        int previousNum = 0;
        int currentNum = 1;



        for (int i = 0; i < n; i++) {

        int nextNum = previousNum;
        previousNum = currentNum;
        currentNum= nextNum + currentNum;


        }
     return previousNum;
    }


}











