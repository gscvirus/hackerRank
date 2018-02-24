import java.util.Scanner;

public class Difference {
    private int[ ] elements;
    public int maximumDifference;

    public Difference( int[ ] array ) {
        this.elements = array;
        this.maximumDifference = 0;
    }

    public void computeDifference( ) {
        int min = elements[ 0 ];
        int max = elements[ 0 ];

        for( int idx = 0; idx < elements.length; idx++ ) {
            if( elements[ idx ] < min ) {
                min = elements[ idx ];
            }
            if( elements[ idx ] > max ) {
                max = elements[ idx ];
            }
        }

        this.maximumDifference = max - min;
    }

}

public class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int n = scanner.nextInt( );
        int[ ] array = new int[ n ];

        for( int idx = 0; idx < n; idx++ ) {
            array[ idx ] = scanner.nextInt( );
        }
        scanner.close( );
        Difference difference = new Difference( array );
        array[ 0 ] = -120000;

        difference.commputeDifference( );

        System.out.println( difference.maximumDifference );
    }
}