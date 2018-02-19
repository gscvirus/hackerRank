import sys

n = int( input( ).strip( ) )
phoneBook = { }

for _ in range( n ):
    contact = input( ).split( ' ' )
    phoneBook[ contact[ 0 ] ] = int( contact[ 1 ] )

while True:
    name = input( ).strip( )
    if len( name ) == 0:
        break
    
    if name in phoneBook:
        print( name + "=" + str( phoneBook[ name ] ) )
    else:
        print( "Not found" )
