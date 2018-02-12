import java.util.Scanner;

public class Person {
    private int age;

    public Person( int initialAge ) {
        if( initialAge < 0 ) {
            initialAge = 0;
            System.out.println( "Age is not valid, setting age to 0." );
        }
        age = initialAge;
    }

    public void amIOld( ) {
        if( age < 13 ) {
            System.out.println( "You are young." );
        } else if( age >= 13 && age < 18 ) {
            System.out.println( "You are a teenager." );
        } else {
            System.out.println( "You are old." );
        }
    }

    public void yearPasses( ) {
        age += 1;
    }
}

public class Solution {
    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in );
        int t = scanner.nextInt( );

        for( int idx = 1; idx <= t; idx++ ) {
            int age = scanner.nextInt( );
            Person person  = new Person( age );

            person.amIOld( );
            for(int jdx = 1; jdx <= 3; jdx++ ) {
                person.yearPasses( );
            }
            person.amIOld( );
            System.in.println( );
        }
    }
}