
import sys

def swap( array, idx, jdx ):
    temp = array[ idx ]
    array[ idx ] = array[ jdx ]
    array[ jdx ] = temp

n = int( input( ).strip( ) )
array = list( map( int, input( ).strip( ).split( ' ' ) ) )
numberOfSwaps = 0

for idx in range( n ):
    for jdx in range( n - 1 ):
        if array[ jdx ] > array[ jdx + 1 ]:
            swap( array, jdx, jdx + 1 )
            numberOfSwaps += 1
    
    if numberOfSwaps == 0:
        break

print( "Array is sorted in " + str( numberOfSwaps ) + " swaps." )
print( "First Element: " + str( array[ 0 ] ) )
print( "Last Element: " + str( array[ n - 1 ] ) )

