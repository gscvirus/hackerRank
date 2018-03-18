import java.util.Scanner;

class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int[ ] returnedDate = new int[ 3 ];
        int[ ] dueDate = new int[ 3 ];
        int fine = 0;

        for( int idx = 0; idx < 3; idx++ ) {
            returnedDate[ idx ] = scanner.nextInt( );
        }

        for( int idx = 0; idx < 3; idx++ ) {
            dueDate[ idx ] = scanner.nextInt( );
        }
        scanner.close( );

        if( returnedDate[ 2 ] == dueDate[ 2 ] ) {
            if( returnedDate[ 1 ] > dueDate[ 1 ] ) {
                fine = 500 * ( returnedDate[ 1 ] - dueDate[ 1 ] );
            } else if( returnedDate[ 1 ] == dueDate[ 1 ] && returnedDate[ 0 ] > dueDate[ 0 ] ) {
                fine = 15 * ( returnedDate[ 0 ] -  dueDate[ 0 ] );
            }
        } else if( returnedDate[ 2 ] > dueDate[ 2 ] ) {
            fine = 10000;
        }

        System.out.println( fine );        
    }
}