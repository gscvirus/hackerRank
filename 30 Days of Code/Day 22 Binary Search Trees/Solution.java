import java.util.Scanner;

class Node {
     Node left;
     Node right;
     int data;

     Node( int data ) {
         left = right = null;
         this.data = data;
     }
}

class Solution {
    public static Node insert( Node root, int data ) {
        if( root == null ) {
            return new Node( data );
        }
        Node current = null;
        if( data < root.data ) {
            current = insert( root.left, data );
            root.left = current;
        } else {
            current = insert( root.right, data );
            root.right = current;
        }

        return root;
    }

    public static int getHeight( Node root ) {
        if( root == null ) {
            return -1;
        }
        int leftHeight = getHeight( root.left ) + 1;
        int rightHeight = getHeight( root.right ) + 1;

        return leftHeight > rightHeight ? leftHeight : rightHeight;
    }

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int T = scanner.nextInt( );
        Node root = null;

        while( T-- > 0 ) {
            int data = scanner.nextInt( );
            root = insert( root, data );
        }
        int height = getHeight( root );
        System.out.println( height );
        scanner.close( );
    }
}