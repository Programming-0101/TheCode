using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Topic.E.Practice.Specs
{
    public class E1_Calculator
    {
        //Should add two whole numbers.
        //Should multiply two whole numbers.

        // NEW
        //Should subtract two whole numbers.
        //Should divide two whole numbers.
    }
}

/*
   FRACTION
Should get the string representation of the fraction, as “numerator/denominator”
Should get the numeric value of the fraction (as a real number)
Should get the reciprocal of the fraction
Should get the numerator and denominator
Should add another fraction to its existing value
Should subtract another fraction from its existing value
Should multiply its existing value by another fraction
Should divide its existing value by another fraction


    SQUARE
Should get and set the length of the side of the square.
Should calculate the area, perimeter, and diagonal of the square.

    COORDINATE
Should get the type of coordinate (such as “longitude” or “latitude”)
Given the hours, minutes and seconds, it
should calculate coordinate value as a real number
should get hours, minutes, and seconds
Given the coordinate value as a real number, it
should calculate the hours, minutes and seconds
should get the coordinate value as a real number

    PAINT_ESTIMATOR
Uses a constant value of 8.0 for the paint coverage. (8 square metres per can)
Should get room height, width, and length
Should get and set the window’s width and height
Should calculate the number of paint cans for the room and the window
Should calculate the surface area to be painted
The room’s height, length and width should have a private set property.

    BULK_ITEM
Should get and set the cost and quantity of the bulk item
Should calculate the cost for each item in the bulk item
Should properly round values for currency (either the US or Canadian dollar)
The Quantity property’s set should be private.

    DIE
The Sides and FaceValue properties’ set should be private.
Should generate a six-sided die by default
Should get the number of sides of the die
Should randomly generate each side (if rolled enough); for example, if the die has ten sides, it should eventually roll a 1, 2, 3, 4, 5 6, 7, 8, 9, and 10

    ROUNDING_CALCULATOR
All of the methods should be static.
Should correctly round up to the nearest thousand
Should correctly round down to the nearest thousand
Should correctly round up to the nearest hundred
Should correctly round down to the nearest hundred
Should correctly round up to the nearest ten
Should correctly round down to the nearest ten
Should correctly round up to the nearest one
Should correctly round down to the nearest one
Should correctly round up to the nearest tenth
Should correctly round down to the nearest tenth
Should correctly round up to the nearest hundredth
Should correctly round down to the nearest hundredth

    GENERIC_ROUNDING_CALCULATOR
All of the methods should be static.
Should correctly round up or down to the nearest whole number, such as
the nearest thousand
the nearest hundred
the nearest ten
the nearest one
Should correctly round up or down to the nearest fractional value, such as
the nearest tenth
the nearest hundredth

    PEOPLE_COUNTER
The Count property should have a private set.
Should default to having a count of zero people when first started up
Should increment by one (that is, count a single person)
Should increment by a specified quantity (for when a group of people enter)
Should adequately estimate the number of people who entered the store, assuming that each person who enters also leaves the store
Each estimate should be rounded down; for example, if 15 people are counted, then the estimate should be for only 7 (not 7.5 or 8)

    SCORE_CARD
Not Yet Implemented This class represents a scorecard for tracking bowling scores frame by frame. It produces a final tally for the game, as well as the current score and the current frame.

    CYLINDER
The Radius and Height properties should have a private set.
Should get the radius and the height
Should calculate the volume and the surface area
Volume of a Cylinder = pi * r^2 * h$
Surface Area of a Cylinder = 2 * pi * r^2 + 2 * pi * r * h

    CONE
The Radius and Height properties should have a private set.
Should get the radius and the height
Should calculate the volume and the surface area
Volume of a Cone = 1/3 * pi * r^2 * h$
Surface Area of a Cone = pi * r^2 + pi * r * sqrt(r^2 + h^2)

    GRAVITY_CALCULATOR
All the methods should be static.
Should convert a weight in Earth kilograms to their equivalent weight on
    Mercury
    Venus
    Mars
    Jupiter
    Saturn
    Uranus
    Neptune
For information on equivalent weights among the planets, see these URLS.
    NinePlanets.org
    http://www.serve.com/chunter/index/info/aweigh.html

    CURRENCY_CALCULATOR
Should correctly convert US dollars to the 
    British Pound (GBP)
    Canadian Dollar (CAD)
    Euro (EUR)
    Japanese Yen (JPY)
Should use the correct level of precision when making the exchange; each currency uses a different number of significant digits:
    CAD, GBP and EUR use two digits
    JPY uses three digits


*/
