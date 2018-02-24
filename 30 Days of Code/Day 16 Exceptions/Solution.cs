using System;

public class Solution {
    public static void Main( String[ ] args ) {
        String S = Console.ReadLine( );

        try {
            Console.WriteLine( $"{Int32.Parse( S )}" );
        } catch {
            Console.WriteLine( "Bad String" );
        }
    }
}