import java.util.Scanner;
import java.util.Map;
import java.util.HashMap;

public class Solution {

    public static void main( String[ ] args ) {
        Scanner scanner = new Scanner( System.in ) ;
        int n = scanner.nextInt( );
        Map< String, Integer > phoneBook = new HashMap< String, Integer >( );

        for( int idx = 1; idx <= n; idx++ ) {
            String name = scanner.next( );
            int phone = scanner.nextInt( );
            
            phoneBook.put( name, new Integer( phone ) );
        }

        while( scanner.hasNext( ) ) {
            String name = scanner.next( );
            if( phoneBook.containsKey( name ) ) {
                System.out.println( name + "=" + phoneBook.get( name ) );
            } else {
                System.out.println( "Not found" );
            }
        }

        scanner.close( );
    }
}