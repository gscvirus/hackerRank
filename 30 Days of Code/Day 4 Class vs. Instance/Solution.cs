using System;

public class Person {
    private int age;

    public Person( int initialAge ) {
        if( initialAge < 0 ) {
            initialAge = 0;
            Console.WriteLine( "Age is not valid, setting age to 0." );
        }
        age = initialAge;
    }

    public void amIOld( ) {
        if( age < 13 ) {
            Console.WriteLine( "You are young." );
        } else if( age >= 13 && age < 18 ) {
            Console.WriteLine( "You are a teenager." );
        } else {
            Console.WriteLine( "You are old." );
        }
    }

    public void yearPasses( ) {
        age += 1;
    }
}

public class Solution {
    static void Main( String[ ]  args ) {
        int t = Convert.ToInt32( Console.ReadLine( ) );

        for( int idx = 1; idx <= t; idx++ ) {
            int age = Convert.ToInt32( Console.ReadLine( ) );
            Person person = new Person( age );

            person.amIOld( );
            for( int jdx = 1; jdx <= 3; jdx++ ) {
                person.yearPasses( );
            }
            person.amIOld( );
            Console.WriteLine( );
        }
    }
}
