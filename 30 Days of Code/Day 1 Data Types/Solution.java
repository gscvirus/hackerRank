import java.util.Scanner;

public class Solution {
    public static void main( String[ ] args ) {
        int i = 4;
        double d = 4.0;
        String s = "HackerRank ";
        Scanner scan = new Scanner( System.in );
        int intValue;
        double doubleValue;
        String strValue;

        intValue = scan.nextInt( );
        doubleValue = scan.nextDouble( );
        scan.nextLine( );
        strValue = scan.nextLine( );

        System.out.println( i + intValue );
        System.out.println( String.format( "%.1f", d + doubleValue ) );
        System.out.println( s + strValue );
        scan.close( );
    }
}