using System;

public class Solution {

    public static int SumHourGlass( int[ ][ ] matrix, int row, int col ) {
        int sum = 0;

        for( int idx = col; idx < col + 3; idx++ ) {
            sum += matrix[ row ][ idx ] + matrix[ row + 2 ][ idx ];
        }
        sum += matrix[ row + 1 ][ col + 1 ];

        return sum;
    }

    public static void Main( String[ ] args ) {
        int[ ][ ] arr = new int[ 6 ][ ];
        int max = Int32.MinValue;

        for( int idx = 0; idx < 6; idx++ ) {
            String[ ] arr_temp = Console.ReadLine( ).Split( ' ' );
            arr[ idx ] = Array.ConvertAll( arr_temp, Int32.Parse );
        }

        for( int row = 0; row < 4; row++ ) {
            for( int col = 0; col < 4; col++ ) {
                int sum = SumHourGlass( arr, row, col );

                if( sum > max ) {
                    max = sum;
                }
            }
        }

        Console.WriteLine( max );
    }
}