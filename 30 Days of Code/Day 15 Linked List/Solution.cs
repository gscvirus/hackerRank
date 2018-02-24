using System;

public class Node {
    public int data;
    public Node next;

    public Node( int data ) {
        this.data = data;
        this.next = null;
    }
}

public class Solution {
    public static Node insert( Node head, int data ) {

        if( head == null ) {
            return new Node( data );
        }

        Node tail = insert( head.next, data );
        head.next = tail;

        return head;
    }

    public static void display( Node head ) {
        Node start = head;

        while( start != null ) {
            Console.WriteLine( $"{start.data} + " );
            start = start.next;
        }
    }

    public static void Main( String[ ] args ) {
        Node head = null;

        int t = Convert.ToInt32( Console.ReadLine( ) );

        while( t-- > 0 ) {
            int data = Convert.ToInt32( Console.ReadLine( ) );
            head = insert( head, data );
        }

        display( head );
    }
}