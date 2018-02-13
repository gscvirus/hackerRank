import java.lang.StringBuilder;
import java.util.Scanner;

public class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int t = scanner.nextInt( );
        StringBuilder bufferEvens = new StringBuilder( );
        StringBuilder bufferOdds = new StringBuilder( );

        scanner.nextLine( );
        for( int count = 1; count <= t; count++ ) {
            String word = scanner.nextLine( );

            for( int idx = 0; idx < word.length( ); idx++ ) {
                if( idx % 2 == 0 ) {
                    bufferEvens.append( word.charAt( idx ) );
                } else {
                    bufferOdds.append( word.charAt( idx ) );
                }
            }

            System.out.println( bufferEvens.toString( ) + " " + bufferOdds.toString( ) );
            bufferEvens.setLength( 0 );
            bufferOdds.setLength( 0 );
        }

    }
}