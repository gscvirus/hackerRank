using System;
using System.Linq;

class Person {
    protected string firstName;
    protected string lastName;
    protected int id;

    public Person( ) {
    }

    public Person( string firstName, string lastName, int identification ) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.id = identification;
    }

    public void printPerson( ) {
        Console.WriteLine( "Name: " + lastName + ", " + firstName + "\nID: " + id );
    }
}

class Student {
    private int testScores;

    public Student( string firstName, string lastName, int id, int[ ] scores ) : base( firstName, lastName, id ) {
        testScores = scores;
    }

    public string Calculate( ) {
        var average = testScores.Average( );

        if( 90 <= average && average <= 100 ) {
            return "O";
        } else if( 80 <= average && average < 90 ) {
            return "E";
        } else if( 70 <= average && average < 80 ) {
            return "A";
        } else if( 55 <= average && average < 70 ) {
            return "P";
        } else if( 40 <= average && average < 55 ) {
            return "D";
        }
        
        return "T";
    }

}

class Solution {
    static void Main( string[ ] args ) {
        string[ ] inputs = Console.ReadLine( ).Split( ) ;
        string firstName = inputs[ 0 ];
        string lastName = inputs[ 1 ];
        int id = Convert.ToInt32( inputs[ 2 ] );
        int numScores = Convert.ToInt32( Console.ReadLine( ) );
        inputs = Console.ReadLine( ).Split( );
        int[ ] scores = new int[ numScores ];
        scores = Array.ConvertAll( inputs, Convert.ToInt32 );

        Student student = new Student( firstName, lastName, id, scores );
        student.printPerson( );
        Console.WriteLine( "Grade: " + student.Calculate( ) + "\n" );
    }
}