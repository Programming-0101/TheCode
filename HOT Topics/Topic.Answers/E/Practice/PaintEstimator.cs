﻿using System;
using System.Linq;

namespace Topic.E.Practice
{
    public class PaintEstimator
    {
        public double RoomHeight { get; set; }
        public double RoomWidth { get; set; }
        public double RoomLength { get; set; }
        public double WindowHeight { get; set; }
        public double WindowWidth { get; set; }
        public const double COVERAGE = 8.0;
        public int PaintCans
        {
            get
            {
                int cans = (int)Math.Ceiling(SurfaceArea / COVERAGE);
                return cans;
            }
        }
        public double SurfaceArea
        {
            get
            {
                // Walls only
                double area = RoomHeight * RoomWidth * 2
                            + RoomHeight * RoomLength * 2
                            - WindowHeight * WindowWidth;
                return area;
            }
        }

        public PaintEstimator(double roomHeight, double roomWidth, double roomLength)
        {
            RoomHeight = roomHeight;
            RoomWidth = roomWidth;
            RoomLength = roomLength;
        }

        public PaintEstimator(double roomHeight, double roomWidth, double roomLength, double windowHeight, double windowWidth)
        {
            RoomHeight = roomHeight;
            RoomWidth = roomWidth;
            RoomLength = roomLength;
            WindowHeight = windowHeight;
            WindowWidth = windowWidth;
        }
    }
}

/*
Calculator – This exercise expands on the original Calculator class to perform subtraction and division with integers.
Fraction – This exercise expands on the original Fraction class to include methods that allow for adding, subtracting, multiplying, and dividing fractions.
Square – This exercise expands on the original Square class to include a method that determines the diagonal of a square.
Coordinate – Not Yet Implemented The Coordinate class represents a geographical co-ordinate for either longitude or latitude. A Coordinate’s value can be expressed either as a real number or as degrees, minutes and seconds. It makes use of integer division and overloaded constructors.
PaintEstimator – The PaintEstimator class is used to estimate the number of paint cans needed for painting a simple room (with or without a window). It makes use of a constant and the Math library; it also uses overloaded constructors.
BulkItem – The BulkItem class represents products that are available in bulk and shows the cost of individual items. It makes use of rounding (to two decimal places).
Die - This exercise expands on the original Die class to allow for creating a die of any number of sides, with a default of six sides. This means that there is an overloaded constructor.
RoundingCalculator – This exercise demonstrates rounding using separate methods for each level of rounding precision.
GenericRoundingCalculator – This exercise demonstrates rounding to the nearest whole number of fractional number using a couple of “generic” methods.
PeopleCounter – This simple class is used to count the number of people who have entered a store in a single day. It takes a simplistic approach, counting each person entering and leaving, estimating the number of people for the day by dividing the total count by two.
ScoreCard – Not Yet Implemented This class represents a scorecard for tracking bowling scores frame by frame. It produces a final tally for the game, as well as the current score and the current frame.
Cylinder – The Cylinder class represents a cylindrical object whose height and radius is known. The class provides methods to calculate the volume and surface area.
Cone – The Cone class represents a conical object whose height and base radius is known. The class provides methods to determine the volume and surface area with this information.
GravityCalculator – The GravityCalculator provides static methods for determining an object’s weight for the various planets in our solar system, given the equivalent weight as found on Earth.
CurrencyCalculator – The CurrencyCalculator allows the conversion of US dollars to four other currencies, given the current exchange rate of those currencies.
 */
