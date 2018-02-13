import java.util.Scanner;

public class Solution {

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int n = scanner.nextInt( );
        int[ ] array = new int[ n ];

        for( int idx = 0; idx < n; idx++ ) {
            array[ idx ] = scanner.nextInt( );
        }

        scanner.close( );
        
        for( int idx = n - 1; idx >= 0; idx-- ) {
            System.out.print( array[ idx ] + " " );
        }
    }
}