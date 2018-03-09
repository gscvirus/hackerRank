class Node:
    def __init__( self, data ):
        self.data = data
        self.left = None
        self.right = None

class Solution:
    def insert( self, root, data ):
        if root == None:
            return Node( data )
        
        if data <= root.data:
            current = self.insert( root.left, data )
            root.left = current
        else:
            current = self.insert( root.right, data )
            root.right = current

        return root
    
    def levelOrder( self, root ):
        if root == None:
            return
        
        queue = [ root ]
        while len( queue ) > 0:
            node = queue.pop( 0 )
            print( node.data, end= ' ' )
            if node.left != None:
                queue.append( node.left )
            if node.right != None:
                queue.append( node.right )


T = int( input( ) )
tree = Solution( )
root = None
for _ in range( T ):
    data = int( input( ) )
    root = tree.insert( root, data )
tree.levelOrder( root )        