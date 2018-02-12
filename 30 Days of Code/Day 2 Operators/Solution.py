#!/bin/python3

import sys

if __name__ == "__main__":
    meal_cost = float( input( ).strip( ) )
    tip_percent = int( input( ).strip( ) )
    tax_percent = int( input( ).strip( ) )

    tip = meal_cost * ( tip_percent / 100 )
    tax = meal_cost * ( tax_percent / 100 )
    totalCost = int( round( meal_cost + tip + tax ) )

    #print( f"The total meal cost is {totalCost} dollars." )
    print( "The total meal cost is {0} dollars.".format( totalCost ) )
