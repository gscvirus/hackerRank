class Node:
    def __init__( self, data ):
        self.right = None
        self.left = None
        self.data = data

class Solution:
    def insert( self, root, data ):
        if root == None:
            return Node( data )
        else:
            if data < root.data:
                current = self.insert( root.left, data )
                root.left = current
            else:
                current = self.insert( root.right, data )
                root.right = current
        
        return root

    def getHeight( self, root ):
        if root == None:
            return -1
        
        leftHeight = self.getHeight( root.left ) + 1
        rightHeight = self.getHeight( root.right ) + 1

        return leftHeight if leftHeight > rightHeight else rightHeight

T = int( input( ) )
tree = Solution( )
root = None
for _ in range( T ):
    data = int( input( ) )
    root = tree.insert( root,  data )
height = tree.getHeight( root )
print( height )
