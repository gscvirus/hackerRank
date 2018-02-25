using System;

class Calculator {
    int power( int n, int p ) {
        if( n < 0 || p < 0 ) {
            throw new Exception( "n and p should be non-negative" );
        }

        return ( int )Math.Pow( n, p );
    }
}

public class Solution {
    public static void Main( String[ ] args ) {
        int T = Convert.ToInt32( Console.ReadLine( ) );
        Calculator calculator = new Calculator( );

        for( int idx = 0; idx < T; idx++ ) {
            string[ ] num = Console.ReadLine( ).Split( );
            int n = int.Parse( num[ 0 ] );
            int p = int.Parse( num[ 1 ] );
            try {
                int result = calculator.power( n, p );
                Console.WriteLine( result );
            } catch( Exception ex ) {
                Console.WriteLine( ex.Message );
            }
        }

    }
}