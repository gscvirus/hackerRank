import sys

n = int( input( ).strip( ) )
array = [ int( arr_temp ) for arr_temp in input( ).strip( ).split( ' ' ) ]
print( ' '.join( map( str, array[::-1] ) ) )