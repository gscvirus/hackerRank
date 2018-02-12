import java.util.Scanner;

public class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );

        int n = scanner.nextInt( );

        for( int idx = 1; idx <= 10; idx++ ) {
            System.out.println( n + " x " + idx + " = " + n * idx );
        }

        scanner.close( );
    }
}