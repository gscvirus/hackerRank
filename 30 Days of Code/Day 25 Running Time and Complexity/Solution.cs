using System;
using System.Linq;

class Solution {

    static bool isEven( int number ) {
        return number % 2 == 0;
    }

    static void Main( String[ ] args ) {
        int T = Int32.Parse( Console.ReadLine( ) );

        for( int idx = 1; idx <= T; idx++ ) {
            int n = Int32.Parse( Console.ReadLine( ) );
            bool isPrime = true;

            if( n == 2 || n == 3 || n == 5 || n == 7 ) {
                isPrime = true;
            } else if( isEven( n ) || n == 1 || n == 9 ) {
                isPrime = false;
            } else {
                int sqrt = Convert.ToInt32( Math.Sqrt( n ) );

                for( int jdx = 3; ( jdx <= sqrt && isPrime ); jdx += 2 ) {
                    if( ( n % jdx ) == 0 ) {
                        isPrime = false;
                    }
                }
            }

            if( isPrime ) {
                Console.WriteLine( "Prime" );
            } else {
                Console.WriteLine( "Not prime" );
            }
            
        }
    }
}