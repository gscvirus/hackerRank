using System;
using System.Linq;

class Solution {
    public static void swap( int[ ] array, int x, int y ) {
        int temp = array[ x ];
        array[ x ] = array[ y ];
        array[ y ] = temp;
    }

    static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        int[ ] array = Console.ReadLine( )
                              .Split( ' ' )
                              .Select( x => Convert.ToInt32( x ) )
                              .ToArray( );
        int numSwaps = 0;

        for( int idx = 0; idx < n - 1; idx++ ) {
            for( int jdx = 0; jdx < n - idx - 1; jdx++ ) {
                if( a[ jdx ] > a[ jdx + 1] ) {
                    swap( a, jdx, jdx + 1 );
                    numSwaps += 1;
                }
            }
            
            if( numSwaps == 0 ) {
                break;
            }
        }        

        Console.WriteLine( $"Array is sorted in {numSwaps} swaps." );
        Console.WriteLine( $"First Element: {a[0]}" );
        Console.WriteLine( $"Last Element: {a[n - 1]}" );
    }
}