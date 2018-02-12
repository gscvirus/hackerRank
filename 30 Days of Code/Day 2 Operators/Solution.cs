using System;

class Solution {
    public static void Main( String[ ] args ) {
        double meal_cost = Convert.ToDouble( Console.ReadLine( ) );
        int tip_percent = Convert.ToInt32( Console.ReadLine( ) );
        int tax_percent = Convert.ToInt32( Console.ReadLine( ) );

        double tip = meal_cost * ( (double)tip_percent / 100 );
        double tax = meal_cost * ( (double)tax_percent / 100 );
        double totalCost = meal_cost + tip + tax;

        Console.WriteLine( $"The total meal cost is {Math.Round( totalCost )} dollars." );
    }
}