import java.util.Scanner;

import com.sun.org.apache.xerces.internal.impl.xpath.regex.ParseException;

public class Solution {
    public static void main( String[ ] args ) {
        Scanner in = new Scanner( System.in );
        String S = in.next( );

        try {
            System.out.println( Integer.parseInt( S ) );
        } catch( NumberFormatException pEx ) {
            System.out.print( "Bad String" );
        }
        in.close( );
    }
}