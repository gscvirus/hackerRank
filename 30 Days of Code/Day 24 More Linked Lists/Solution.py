class Node:
    def __init__( self, data ):
        self.data = data
        self.next = None

class Solution:
    def insert( self, head, data ):
        if head == None:
            return Node( data )
        
        current = self.insert( head.next, data )
        head.next = current

        return head


    def display( self, head ):
        if head != None:
            print( head.data, end=' ' )
            self.display( head.next )


    def removeDuplicates( self, head ):
        if head == None:
            return head

        current = head
        next = current.next
        while current.next != None:
            if current.data == next.data:
                current.next = next.next
            else:
                current = next
            next = next.data
        
        return head


T = int( input( ) )
solution = Solution( )
head = None
for _ in range( T ):
    data = int( input( ) )
    solution.insert( head, data )
head = solution.removeDuplicates( head )
solution.display( head )