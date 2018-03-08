using System;

class Node {
    public Node left;
    public Node right;
    public int Data;

    public Node( int data ) {
        this.data = data;
        this.left = this.right = null;
    }
}

class Solution {

    static Node insert( Node root, int data ) {
        if( root == null ) {
            root = new Node( data );
        } else {
            Node current;
            if( data <= root.data ) {
                current = insert( root.left, data );
                root.left = current;
            } else {
                current = insert( root.right, data );
                root.right = current;
            }
        }

        return root;
    }

    static int getHeight( Node root ) {
        int leftHeight = 0;
        int rightHeight = 0;

        if( root.left != null ) {
            leftHeight = getHeight( root.left ) + 1;
        }
        if( root.right != null ) {
            rightHeight = getHeight( root.right ) + 1;
        }

        return leftHeight > rightHeight ? leftHeight : rightHeight;
    }

    static void Main( String[ ] args ) {
        Node root = null;

        int T = Int32.Parse( Console.ReadLine( ) );
        while( T-- > 0 ) {
            int data = Int32.Parse( Console.ReadLine( ) );
            root = insert( root, data );
        }
        int height = getHeight( root );
        Console.WriteLine( height );
    }
}