import java.util.Scanner;

interface AdvancedArithmetic {
    int divisorSum( int n );
}

class Calculator implements AdvancedArithmetic {
    public int divisorSum( int n ) {
        int sum = 1;

        for( int idx = 2; idx <= n; idx++ ) {
            if( n % idx == 0 ) {
                sum += idx;
            }
        }

        return sum;
    }
}

class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int n = scanner.nextInt( );
        scanner.close( );

        AdvancedArithmetic calculator = new Calculator( );
        int sum = calculator.divisorSum( n );
        System.out.println( "I implemented: " + calculator.getClas( ).getInterfaces( )[ 0 ].getName( ) );
        System.out.println( sum );
    }
}