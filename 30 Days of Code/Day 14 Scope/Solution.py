class Difference:
    def __init__( self, array ):
        self.__elements = array

    def computeDifference( self ):
        min = self.__elements[ 0 ]
        max = self.__elements[ 0 ]

        for idx in range( 1, len( self.__elements ) ):
            if self.__elements[ idx ] < min:
                min = self.__elements[ idx ]
            if self.__elements[ idx ] > max:
                max = self.__elements[ idx ]

        self.maximumDifference = max - min
            

_ = int( input( ).strip( ) )
array = [ x for x in input( ).split( ' ' ) ]
diff = Difference( array )
diff.computeDifference( )
print( diff.maximumDifference )