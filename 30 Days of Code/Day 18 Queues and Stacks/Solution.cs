using System;
using System.Collections.Generic;

class Solution {

    Stack< char > stack = new Stack< char >( );
    Queue< char > queue = new Queue< char >( );

    public void pushCharacter( char c ) {
        stack.Push( c );
    }

    public void enqueueCharacter( char c ) {
        queue.Enqueue( c );
    }

    public char popCharacter( ) {
        return stack.Pop( );
    }

    public char dequeueCharacter( ) {
        return queue.Dequeue( );
    }

    public static void Main( String[ ] args ) {
        String s = Console.ReadLine( );
        Solution obj = new Solution( );

        foreach( char c in s ) {
            obj.pushCharacter( c );
            obj.enqueueCharacter( c );
        }

        bool isPalindrome = true;
        
        for( int idx = 0; idx < s.Length / 2; idx++ ) {
            if( obj.popCharacter( ) != obj.dequeueCharacter( ) ) {
                isPalindrome = false;
                break;
            }
        }

        if( isPalindrome ) {
            Console.WriteLine( "The word, {0}, is a palindrome.", s );
        } else {
            Console.WriteLine( "The word, {0}, is not a plaindrome.", s );
        }
    }
}