using System;

public class Difference {
    private int[ ] elements;
    public int maximumDifference;

    public Difference( int[ ] array ) {
        this.elements = array;
        this.maximumDifference = 0;
    }

    public void computeDifference( ) {
        int min = elements[ 0 ];
        int max = elements[ 0 ];

        for( int idx = 1; idx < elements.Length; idx++ ) {
            if( elements[ idx ] < min ) {
                min = elements[ idx ];
            }
            if( elements[ idx ] > max ) {
                max = elemenets[ idx ];
            }
        }

        this.maximumDifference = max - min;
    }

}

class Solution {
    static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        int[ ] array = Console.ReadLine( )
                              .Split( ' ' )
                              .Select( x => Convert.ToInt32( x ) )
                              .ToArray( );

        Diferrence difference = new Difference( array );
        difference.computeDifference( );

        Console.WriteLine( difference.maximumDifference );
    }
}