class Person:

    def __init__( self, initialAge ):
        if initialAge < 0:
            initialAge = 0
            print( "Age is not valid, setting age to 0." )
        self.age = initialAge
    
    def yearPasses( self ):
        self.age += 1
    
    def amIOld( self ):
        if self.age < 13:
            print( "You are young." )
        elif self.age >= 13 and self.age < 18:
            print( "You are a teenager." )
        else:
            print( "You are old." )

t = int( input( ) )
for idx in range( 0, t ):
    age = int( input( ) )
    person = Person( age )

    person.amIOld( )
    for jdx in range( 3 ):
        person.yearPasses( )
    person.amIOld( )
    print( "" )