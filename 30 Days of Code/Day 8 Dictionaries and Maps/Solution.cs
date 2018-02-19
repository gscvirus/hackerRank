using System;
using System.Collections.Generic;
using System.IO;
class Solution {
    static string ReadName( ) {
        string name = Console.ReadLine( ) ;
        
        return name;
    }
    
    static void Main(String[] args) {
        IDictionary< string, int > phoneBook = new Dictionary< string, int >( );
        int n = Int32.Parse( Console.ReadLine( ) );
        
        for( int idx = 1; idx <= n; idx++ ) {
            string[ ] line = Console.ReadLine( ).Split( ' ' );
            phoneBook.Add( line[ 0 ], Int32.Parse( line[ 1 ] ) );    
        }
        
        string name = ReadName( );
        int phone;
        while( !String.IsNullOrEmpty( name ) ) {
            if( phoneBook.TryGetValue( name, out phone ) ) {
                Console.WriteLine( $"{name}={phone}" );
            } else {
                Console.WriteLine( "Not found" );
            }
            name = ReadName( );
        }
    }
}