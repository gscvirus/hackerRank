using System;
using System.Linq;

public class Solution {
    
    public static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        string[ ] arr = Console.ReadLine( ).Split( ' ' );
        int[ ] array = Array.ConvertAll(arr, Int32.Parse );

        foreach( int item in array.Reverse( ) ) {
            Console.Write( $"{item} " );
        }
    }
}