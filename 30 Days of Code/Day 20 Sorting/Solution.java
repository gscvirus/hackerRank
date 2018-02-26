import java.util.Scanner;

public class Solution {

    static void swap( int[ ] array, int idx, int jdx ) {
        int temp = array[ idx ];
        array[ idx ] = array[ jdx ];
        array[ jdx ] = temp;
    }

    public static void main( String[ ] args ) {
        Scanner in = new Scanner( System.in );
        int n = in.nextInt( );
        int[ ] array = new int[ n ];

        for( int idx = 0; idx < n; idx++ ) {
            array[ idx ] = in.nextInt( );
        }
        in.close( );

        for( int idx = 0; idx < n; idx++ ) {
            int numberOfSwaps = 0;

            for( int jdx = 0; jdx < n - 1; jdx++ ) {
                if( a[ jdx ] > a[ jdx + 1 ] ) {
                    swap( a, jdx, jdx + 1);
                    numberOfSwaps += 1;
                }
            }

            if( numberOfSwaps == 0 ) {
                break;
            }
        }

        System.out.println( "Array is sorted in " + numberOfSwaps + " swaps." );
        System.out.println( "First Element: " + array[ 0 ] );
        System.out.println( "Last Element: " + array[ n - 1 ] );        
    }
}