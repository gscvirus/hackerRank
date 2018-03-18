using System;
using System.Linq;

class Solution {
    public static void Main( String[ ] args ) {
        int[ ] returnedDate = Console.ReadLine( )
                                     .Split( ' ' )
                                     .Select( x => Convert.ToInt32( x ) )
                                     .ToArray( );
        int[ ] dueDate = Console.ReadLine( )
                                .Split( ' ' )
                                .Select( x => Convert.ToInt32( x ) )
                                .ToArray( );

        int fine = 0;

        if( returnedDate[ 2 ] == dueDate[ 2 ] ) {
            if( returnedDate[ 1 ] > dueDate[ 1 ] ) {
                fine = 500 * ( returnedDate[ 1 ] - dueDate[ 1 ] );
            } else if( returnedDate[ 1 ] == dueDate[ 1 ] && returnedDate[ 0 ] > dueDate[ 0 ] ) {
                fine = 15 * ( returnedDate[ 0 ] -  dueDate[ 0 ] );
            }
        } else if( returnedDate[ 2 ] > dueDate[ 2 ] ) {
            fine = 10000;
        }

        Console.WriteLine( fine );
    }
}
