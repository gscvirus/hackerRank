import sys

class Calculator:
    def power( self, n, p ):
        if n < 0 or p < 0:
            raise ValueError( "n and p should be non-negative" )
        return n**p

T = int( input( ).strip( ) )
calculator = Calculator( )
for _ in range( T ):
    n,p = map( int, input( ).split( ) )
    try:
        result = calculator.power( n, p )
        print( result )
    except Exception as e:
        print( e )