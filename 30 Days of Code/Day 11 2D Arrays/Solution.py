import sys

def sumHourGlass( arr, row, col ):
    sum = 0
    for idx in range( col, col + 3 ):
        sum += arr[ row ][ idx ] + arr[ row + 2 ][ idx ]
    sum += arr[ row + 1 ][ col + 1 ]

    return sum


arr = [ ]
max = -100
for idx in range( 6 ):
    arr_t = [ int( value ) for value in input( ).strip( ).split( ' ' ) ]
    arr.append( arr_t )

for row in range( 4 ):
    for col in range( 4 ):
        sum = sumHourGlass( arr, row, col )
        if sum > max:
            max = sum

print( max )