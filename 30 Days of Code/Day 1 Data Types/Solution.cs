using System;

public class Solution 
{
    public static void Main( String[ ] args ) {
        int i = 4;
        double d = 4.0;
        string s = "HackerRank ";

        int intValue = Int32.Parse( Console.ReadLine( ) ) ;
        double doubleValue = Double.Parse( Console.ReadLine( ) );
        String strValue = Console.ReadLine( );

        Console.WriteLine( i + intValue );
        Console.WriteLine( $"{d + doubleValue:.0}" );
        Console.WriteLine( s + strValue );
    }
}