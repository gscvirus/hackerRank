using System;

public interface AdvancedArithmetic {
    int divisorSum( int n );
}

class Calculator : AdvancedArithmetic {
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
    static void main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        Calculator calculator = new Calculator( );
        int sum = calculator.divisorSum( n );
        Console.WriteLine( "I implemented: AdvancedArithmetic \n" + sum );
    }
}