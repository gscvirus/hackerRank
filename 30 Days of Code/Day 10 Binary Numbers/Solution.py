import sys

def convertToBinary( number ):
    if number == 0:
        return "0"
    if number == 1:
        return "1"
    return convertToBinary( int( number / 2 ) ) + str( number % 2 )


def intToBinary( number ):
    MASK = 1
    binary = ""

    while number > 0:
        binary = str( number & MASK ) + binary
        number = number >> 1
    return binary


def getMaxConsecutive( binary ):
    max = 0
    count = 0
    for digit in binary:
        if digit == '1':
            count += 1
        else: 
            if count > max:
                max = count
            count = 0
    if count > max:
        max = count
    return max


n = int( input( ).strip( ) )
binary = intToBinary( n )
result = getMaxConsecutive( binary )
print( result )