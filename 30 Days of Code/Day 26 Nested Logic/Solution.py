
returnedDate = [ int( x ) for x in input( ).split( ' ' ) ]
dueDate = [ int( x ) for x in input( ).split( ' ' ) ]
fine = 0

if returnedDate[ 2 ] > dueDate[ 2 ]:
    fine = 10000
elif returnedDate[ 2 ] < dueDate[ 2 ]:
    fine = 0
elif returnedDate[ 2 ] == dueDate[ 2 ] and returnedDate[ 1 ] > dueDate[ 1 ]:
    fine = 500 * ( returnedDate[ 1 ] - dueDate[ 1 ] )
elif returnedDate[ 1 ] == dueDate[ 1 ] and returnedDate[ 0 ] > dueDate[ 0 ]:
    fine = 15 * ( returnedDate[ 0 ] - dueDate[ 0 ] )

print( fine )
