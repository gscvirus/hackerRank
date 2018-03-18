import math

def isEven( number ):
    return ( number % 2 ) == 0

def isPrime( number ):
    if number == 2:
        return True
    if number == 1 or number == 9 or isEven( number ):
        return False
    idx = 1
    for x in range( 3, math.ceil( math.sqrt( number ) ) + 1, 2):
        if number % x == 0:
            return False
        idx += 1
        
    print( idx )

    return True

T = int( input( ).strip( ) )
for idx in range( T ):
    n = int( input( ).strip( ) )
    message = "Prime" if isPrime( n ) else "Not prime"
    print( message )
