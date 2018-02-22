import java.util.Scanner;

public class Solution {
    private static int sumHourGlass( int[ ][ ] arr, int row, int col ) {
        int sum = 0;

        for( int idx = col; idx < col + 3; idx++ ) {
            sum += arr[ row ][ idx ] + arr[ row + 2 ][ idx ];
        }
        sum += arr[ row + 1 ][ col + 1 ];

        return sum;
    }

    public static void main( String[ ] args ) {
        Scanner in = new Scanner( System.in );
        int arr[ ][ ] = new int[ 6 ][ 6 ];
        int max = -63;

        for( int row = 0; row < 6; row++ ) {
            for( int col = 0; col < 6; col++ ) {
                arr[ row ][ col ] = in.nextInt( );
            }
        }

        for( int row = 0; row < 4; row++ ) {
            for( int col = 0; col < 4; col++ ) {
                int sum = sumHourGlass( arr, row, col );

                if( sum > max ) {
                    max = sum;
                }
            }
        }

        System.out.println( max );

        in.close( );
    }
}