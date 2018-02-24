class Node:
    def __init__( self, data ):
        self.data = data
        self.next = None

class Solution:
    def display( self, head ):
        current = head
        while current:
            print( current.data, end=' ' )
            current = current.next

    def insert( self, head, data ):
        if head == None:
            return Node( data )

        tail = self.insert( head.next, data )
        head.next = tail

        return head

myList = Solution( )
T = int( input( ).strip( ) )
head = None
for _ in range( T ):
    data = int( input( ).strip( ) )
    head = myList.insert( head, data )

myList.display( head )