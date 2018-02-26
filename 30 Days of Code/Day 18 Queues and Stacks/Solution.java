import java.util.Scanner;
import java.util.Stack;
import java.util.ArrayList;

public class Solution {
    private Stack< Character > stack = new Stack< Character >( );
    private ArrayList< Character > queue = new ArrayList< Character >( );

    public void pushCharacter( char c ) {
        stack.push( new Character( c ) );
    }

    public void enqueueCharacter( char c ) {
        queue.add( new Character( c ) );
    }

    public char popCharacter( ) {
        return stack.pop( ).charValue( );
    }

    public char dequeueCharacter( ) {
        return queue.remove( 0 ).charValue( );
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.io );
        String s = scanner.nextLine( );

        scanner.close( );
        char[ ] characters = s.toCharArray( );
        Solution solution = new Solution( );

        for( char c : characters ) {
            solution.pushCharacter( c );
            solution.enqueueCharacter( c );
        }

        boolean isPalindrome = true;
        for( int idx = 0; idx < s.length / 2; idx++ ) {
            if( solution.popCharacter( ) != solution.dequeueCharacter( ) ) {
                isPalindrome = false;
                break;
            }
        }

        System.out.println( "The word, " + s + ", is " + ( ( !isPalindrome ) ? "not a palindrome." : "a palindrome." ) );
    }
}
