using System;

public class Solution {

    public static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );

        for( int idx = 1; idx <= 10; idx++ ) {
            Console.WriteLine( $"{n} x {idx} = {n * idx}" );
        }
    }
}