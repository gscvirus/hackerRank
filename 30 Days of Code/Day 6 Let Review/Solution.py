t = int( input( ).strip( ) )

for count in range( t ):
    word = input( )

    print( "".join( word[0::2] ) + " " + "".join( word[1::2] ) )
