
class Person:
    def __init__( self, fistName, lastName, idNumber ):
        self.firstName = firstName
        self.lastName = lastName
        self.idNumber = idNumber

    def printPerson( self ):
        print( "Name: " + self.firstName + "," + self.lastName )
        print( "ID: ", self.idNumber )


class Student( Person ):
    def __init__( self, firstName, lastName, id, scores ):
        self.testScore = scores
        super( Student, self ).__init__( firstName, lastName, id )

    def calculate( self ):
        average = sum( self.testScore ) / len( self.testScore )
        if 90 <= average and average <= 100:
            return "O"
        elif 80 <= average and average < 90:
            return "E"
        elif 70 <= average and average < 80:
            return "A"
        elif 55 <= average and average < 70:
            return "P"
        elif 40 <= average and average < 55:
            return "D"

        return "T" 


line = input( ).split( )
firstName = line[  0 ]
lastName = line[ 1 ]
idNumber = line[ 2 ]
numScores = int( input( ).strip( ) )
scores = list( map( int, input( ).split( ) ) )
student = Student( firstName, lastName, idNumber, scores )
student.printPerson( )
print( "Grade:", student.calculate( ) )