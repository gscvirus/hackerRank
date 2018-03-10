using System;

class Node {
    public int data;
    public Node next;

    public Node( int data ) {
        this.data = data;
        next = null;
    }
}

class Solution {
    public static Node removeDuplicates( Node head ) {
        if( head == null ) {
            return head;
        }

        Node current = head;
        Node next = current.next;
        while( current.next != null ) {
            if( next.data == current.data ) {
                current.next = next.next;
            } else {
                current = next;
            }
            next = next.next;
        }

        return head;
    }
    
    public static Node insert( Node head, int data ) {
        if( head == null ) {
            return new Node( data );
        }

        Node current = insert( head.next, data );
        head.next = current;

        return head;
    }

    public static void display( Node head ) {
        if( head != null ) {
            Console.Write( $"{head.data} " );
            display( head.next );
        }
    }

    public static void Main( String[ ] args ) {
        Node head = null;
        int T = Convert.ToInt32( Console.ReadLine( ) );

        while( T-- > 0 ) {
            int data = Convert.ToInt32( Console.ReadLine( ) );
            head = insert( head, data );
        }
    }
}