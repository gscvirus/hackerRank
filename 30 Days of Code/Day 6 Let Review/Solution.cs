using System;
using System.Linq;
using System.Text;

public class Solution {
    private static bool isEven( int number ) => number % 2 == 0;

    public static void Main( string[ ] args ) {
        int t = Convert.ToInt32( Console.ReadLine( ) );
        StringBuilder bufferEvens = new StringBuilder( );
        StringBuilder bufferOdds = new StringBuilder( );

        for( int count = 1; count <= t; count++ ) {
            string word = Console.ReadLine( );

            for( int idx = 0; idx < word.Length; idx++ ) {
                if( isEven( idx ) ) {
                    bufferEvens.Append( word[ idx ] );
                } else {
                    bufferOdds.Append( word[ idx ] );
                }
            }
            Console.WriteLine( bufferEvens.ToString( ) + " " + bufferOdds.ToString( ) );
            bufferEvens.Clear( );
            bufferOdds.Clear( );
        }
    }
}