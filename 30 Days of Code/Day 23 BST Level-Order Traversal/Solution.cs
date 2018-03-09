using System;
using System.Collections.Generics;

class Node {
    public Node left;
    public Node right;
    public int data;

    public Node( int data ) {
        this.data = data;
        this.left = this.right = null;
    }
}

public class Solution {

    static Node insert( Node root, int data ) {
        if( root == null ) {
            return new Node( data );
        }
        
        Node current = null;

        if( data <= root.data ) {
            current = insert( root.left, data );
            root.left = current;
        } else {
            current = insert( root.right, data );
            root.right = current;
        }

        return root;
    }

    static void levelOrder( Node root ) {
        if( root == null ) {
            return;
        }

        Queue< Node > queue = new Queue< Node >( );

        queue.Enqueue( root );
        while( queue.Count > 0 ) {
            var node = queue.Dequeue( );
            
            Console.Write( $"{node.data} " );
            if( node.left != null ) {
                queue.Enqueue( node.left );
            }
            if( node.right != null ) {
                queue.Enqueue( node.right );
            }
        }        
    }

    static void Main( String[ ] args ) {
        int T = Int32.Parse( Console.ReadLine( ) );
        Node root = null;
        while( T-- > 0 ) {
            int data = Int32.Parse( Console.ReadLine( ) );
            root = insert( root, data );
        }
        levelOrder( root );
    }
}