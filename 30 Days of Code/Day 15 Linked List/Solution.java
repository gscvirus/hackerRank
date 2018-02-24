import java.util.Scanner;

public class Node {
    public Node next;
    public int data;

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
            System.out.print( start.data + " " );
            start = start.next;
        }
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int n = scanner.nextInt( );

        scanner.close( );
    }
}