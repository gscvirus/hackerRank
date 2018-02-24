using System;

abstract class Book {
    protected String title;
    protected String author;

    public Book( String title, String author ) {
        this.title = title;
        this.author = author;
    }

    public abstract void display( );
}

class MyBook : Book {
    private int price;

    public MyBook( String title, String author, int price ) : base( title, author ) {
        this.price = price;
    }

    public override void display( ) {
        Console.WriteLine( $"Title: {this.title}" );
        Console.WriteLine( $"Author: {this.author}" );
        Console.WriteLine( $"Price: {this.price}" );
    }
}

public class Solution {
    static void Main( String[ ] args ) {
        String title = Console.ReadLine( );
        String author = Console.ReadLine( );
        int price = Int32.Parse( Console.ReadLine( ) );

        Book new_novel = new MyBook( title, author, price );
        new_novel.display( );
    }
}