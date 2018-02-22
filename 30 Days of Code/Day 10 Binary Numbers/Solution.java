import java.util.Scanner;

public class Solution {
    private static String convertToBinary( int n ) {
        if( n == 0 ) {
            return "0";
        }
        if( n == 1 ) {
            return "1";
        }
        return convertToBinary( n / 2 ) + ( n % 2 );
    }
    private static String intToBinary( int number ) {
        final int mask = 1;
        String binary = "";
        
        while( number > 0 ) {
            binary = ( number & mask ) + binary;
            number = number >> 1;
        }
        return binary;
    }
    private static int getMaxConsecutive( String binary ) {
        int max = 0;
        int count = 0;

        for( int idx = 0; idx < binary.length( ); idx++ ) {
            if( binary.charAt( idx ) == '0' ) {
                if( count >  max ) {
                    max = count;
                }
                count = 0;
            } else {
                count += 1;
            }
        }

        if( count > max ) {
            max = count;
        }
        
        return max;
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int n = scanner.nextInt( );
        String binary = intToBinary( n );
        scanner.close( );
        int max = getMaxConsecutive( binary );
        System.out.println( max );
    }
}