using System;

class Printer {
    public static void PrintArray< T >( T[ ] array ) {
        for( int idx = 0; idx < array.Length; idx++ ) {
            Console.WriteLine( $"{array[ idx ]}" );
        }
    }

    static void Main( String[ ] args ) {
        int n = Convert.ToInt32( Console.ReadLine( ) );
        int[ ] intArray = new int[ n ];

        for( int idx = 0; idx < n; idx++ ) {
            intArray[ idx ] = Convert.ToInt32( Connsole.ReadLine( ) );
        } 

        n = Convert.ToInt32( Console.ReadLine( ) );
        string[ ] stringArray = new string[ n ];
        for( int idx = 0; idx < n; idx++ ) {
            stringArray[ idx ] = Convert.ToInt32( Connsole.ReadLine( ) );
        } 

        PrintArray< Int32 >( intArray );
        PrintArray< String >( stringArray );
    }
}