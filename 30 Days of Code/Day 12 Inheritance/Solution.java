import java.util.Scanner;

class Person {
    protected String firstName;
    protected String lastName;
    protected int idNumber;

    public Person( String firstName, String lastName, int identification ) {
        this.firstName = firstName;
        this.lastName = lastName;
        this.idNumber = identification;
    }

    public void printPerson( ) {
        System.out.println( "Name: " + lastName + ", " + firstName + "\nID: " + idNumber );
    }
}

public class Student extends Person {
    private int[ ] testScores;

    public Student( String firstName, String lastName, int identification, int[ ] scores ) {
        super( firstName, lastName, identification );
        this.testScores = scores;
    }

    public String calculate( ) {
        int average = 0;
        int sum = 0;

        for( int idx = 0; idx < testScores.length; idx++ ) {
            sum += testScores[ idx ];
        }
        average = ( int )testScores / testScores.length;

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

public class Solution {
    public static void main( String[ ] args ) {
        Scanner scan = new Scanner( System.in );
        String firstName = scan.next( );
        String lastName = scan.next( ) ;
        int id = scan.nextInt( ) ;
        int numScores = scan.nextInt( );
        int[ ] scores = new int[ numScores ];

        for( int idx = 0; idx < numScores; idx++ ) {
            scores[ idx ] = scan.nextInt( );
        }
        scan.close( );

        Student student = new Student( firstName, lastName, id, scores );
        student.printPerson( );
        System.out.println( "Grade: " + student.calculate( ) );
    }
}