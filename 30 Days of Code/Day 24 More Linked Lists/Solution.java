import java.util.Scanner;

class Node {
    public int data;
    public Node next;

    public Node( int data ) {
        this.data = data;
        this.next = null;
    }
}

class Solution {
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
            System.out.print( head.data + " " );
            display( head.next );
        }
    }

    public static Node removeDuplicates( Node head ) {
        if( head == null ) {
            return head;
        }

        Node current = head;
        Node next = current.next;
        while( current.next != null ) {
            if( current.data == next.data ) {
                current.next = next.next;
            } else {
                current = next;
            }
            next = next.next;
        }

        return head;
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int T = scanner.nextInt( );
        Node head = null;

        while( T-- > 0 ) {
            int data = scanner.nextInt( );
            head = insert( head, data )
        }
        head = removeDuplicates( head );
        display( head );
    }
}