import java.util.Scanner;
import java.lang.Math;

class Solution {

    private static boolean isEven( int number ) {
        return number % 2 == 0;
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in ) ;
        int T = scanner.nextInt( );

        for( int idx = 1; idx <= T; idx++ ) {
            int n = scanner.nextInt( );
            boolean isPrime = true;

            if( n == 2 || n == 3 || n == 5 || n == 7 ) {
                isPrime = true;
            } else if( isEven( n ) || n == 1 || n == 9 ) {
                isPrime = false;
            } else {
                int sqrt = ( int )Math.sqrt( n );

                for( int jdx = 3; ( jdx <= sqrt && isPrime ); jdx += 2 ) {
                    if( ( n % jdx ) == 0 ) {
                        isPrime = false;
                    }
                }                
            }

            if( isPrime ) {
                System.out.println( "Prime" );
            } else {
                System.out.println( "Not prime" );
            }
        }

        scanner.close( );
    }
}