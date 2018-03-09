import java.util.ArrayList;
import java.util.Scanner;

class Node {
    Node left;
    Node right;
    int data;

    Node( int data ) {
        this.data = data;
        left = right = null;
    }
}

class Solution {
    public static void levelOrder( Node root ) {
        if( root == null ) {
            return;
        }
        ArrayList< Node > queue = new ArrayList< Node >( );
        queue.add( root );
        
        while( queue.size( ) > 0 ) {
            Node node = queue.remove( 0 );
            System.out.print( node.data + " " );
            if( node.left != null ) {
                queue.add( node.left );
            }
            if( node.right != null ) {
                queue.add( node.right );
            }
        }
    }

    public static Node insert( Node root, int data ) {
        if( root == null ) {
            return new Node( data );
        }

        if( data < root.data ) {
            Node current = insert( root.left, data );
            root.left = current;
        } else {
            Node current = insert( root.right, data );
            root.right = current;
        }

        return root;
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int T = scanner.nextInt( );
        Node root = null;

        while( T-- > 0 ) {
            int data = scanner.nextInt( );
            root = insert( root, data );
        }
        levelOrder( root );
    }
}