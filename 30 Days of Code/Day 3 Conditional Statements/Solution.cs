using System;

public class Solution {
    private static bool IsOdd( int number ) {
        return number % 2 != 0;
    }

    public static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );

        if( IsOdd( n ) ) {
            Console.WriteLine( "Weird" );
        } else {
            if( n >= 2 && n <= 5 ) {
                Console.WriteLine( "Not Weird" );
            } else if( n >= 6 && n <= 20 ) {
                Console.WriteLine( "Weird" );
            } else {
                Console.WriteLine( "Not Weird" );
            }
        }
    }
}