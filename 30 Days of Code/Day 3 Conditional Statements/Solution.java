import java.util.Scanner;

public class Solution {
    private static boolean isOdd( int number ) {
        return number % 2 != 0;
    }

    public static void main( String[ ] args ) {
        Scanner scan = new Scanner( System.in );
        int n = scan.nextInt( );
        String ans = "";

        scan.close( );

        if( isOdd( n ) ) {
            ans = "Weird";
        } else if( n >= 2 && n <= 5 ) {
            ans = "Not Weird";
        } else if( n >= 6 && n <= 20 ) {
            ans = "Weird";
        } else {
            ans = "Not Weird";
        }

        System.out.println( ans );
    }
}