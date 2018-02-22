public class Solution {
    private static string ConvertToBinary( int n ) {
 
         if( n == 0 ) {
             return "0";
         }
         if( n == 1 ) {
             return "1";
         }
 
        return $"{ConvertToBinary( n / 2 )}{n % 2}";
     }
 
    private static string IntToBinary( int n ) {
        const int mask = 1;
        string binary = String.Empty;

        while( number > 0 ) {
            binary = ( number & mask ) + binary;
            number = number >> 1;
        }

        return binary;
    }

    private static int GetMaxConsecutive( string binary ) {
        int max = 0;
        int count = 0;

        foreach( var digit in binary ) {
            if( digit == '0' ) {
                if( count >  max ) {
                    max = count;
                }
                count = 0;
            } else {
                count += 1;
            }
        }

        if( count > max ) {
            max = count;
        }
        
        return max;
    }


    public static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        string binary = ConvertToBinary( n );
        int max = GetMaxConsecutive( binary );
 
        Console.WriteLine( max );
    }
 }