#!/bin/python3

import sys

def isOdd( number ):
    return number % 2 != 0

n = int( input( ).strip( ) )
if isOdd( n ):
    print( "Weird" )
else:
    if n >= 2 and n <= 5:
        print( "Not Weird" )
    elif n >= 6 and n <= 20:
        print( "Weird" )
    else:
        print( "Not Weird" )
