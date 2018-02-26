class Solution:
    def __init__( self ):
        self.__stack = [ ]
        self.__queue = [ ]

    def pushCharacter( self, c ):
        self.__stack.append( c )

    def enqueueCharacter( self, c ):
        self.__queue.append( c )

    def popCharacter( self ):
        return self.__stack.pop( )

    def dequeueCharacter( self ):
        return self.__queue.pop( 0 )

s = input( )
obj = Solution( )
for idx in len( s ):
    obj.pushCharacter( s[ i ] )
    obj.enqueueCharacter( s[ i ] )
isPalindrome = True
for _ in range( len( s ) / 2):
    if obj.popCharacter( ) != obj.dequeueCharacter( ):
        isPalindrome = False
        break

if isPalindrome:
    print( "The word, " + s + ", is a palindrome." )
else:
    print( "The word, " + s + ", is not a palindrome." )
