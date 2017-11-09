using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E3_Account    {
        //Should get the bank name, branch number, institution number, account number, balance, overdraft limit, and account type
        //Should allow the overdraft limit to be set

        // NEW
        //Should support deposits and withdrawals
    }
    public abstract class E4_ElapsedTime {
        //Should calculate the hours, minutes and seconds given the total seconds
        //Should calculate the total seconds given the hours, minutes and seconds
    }
    public abstract class E5_ResolveExpressions
    {
        //10.0 + 15 / 2 + 4.3
        //8 / 5 + 1.25
        //10.0 + 15.0 / 2 + 4.3
        //3.0 * 4 / 6 + 6
        //3.0 * (4 % 6) + 6
        //3 * 4.0 / 6 + 6
        //20.0 - 2 / 6 + 3
        //10 + 17 % 3 + 4
        //(10 + 17) % 3 +4.0
        //10 + 17 / 4.0 + 4
    }
    public abstract class E10_StockTime {
        //Should get and set the name, cost and profit margin of the stock item
        //Should represent the profit margin as a percent; a value of 45 means 45%
        //Should calculate the price of the item, to the nearest cent
        //Use the rounding where values under a half-cent are rounded down and values greater than or equal to a half-cent are rounded up
    }
    public abstract class E11_Die : ReflectionBase
    {
        // TODO: Need to figure out a way to test "random numbers"....
        private dynamic New(int numerator, int denominator)
        {
            return NewSUT(numerator, denominator);
        }
        //Should get the numerator/denominator
        [Fact, Trait("New Tests", "Topic E Die Example")]
        public void Should_Get_Numerator()
        {
            throw new NotImplementedException();
            // Arrange
            var expected = 8;
            var sut = New(8, 4);

            // Act
            var actual = sut.Numerator;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Should generate a random value from 1 to 6, when initially created and when re-rolled
        //Should get the face value of the die
    }
    public abstract class E12_ParkingCounter {
        //Should track vehicles entering
        //Should track vehicles leaving
        //Should get total parking spots
        //Should get open(empty) spots
        //Should reset lot as full(that is, fill the parking lot)
        //Should reset lot as empty(that is, clear all the parking spots of vehicles)
    }
    public abstract class E13_QuadraticEquation {
        //Should get the lower root, using the quadratic formula
        //x = (-b -√(b^2-4ac))/2a$
        //Should get the higher root, using the quadratic formula
        //x = (-b +√(b^2-4ac))/2a$
        //Should overload the ToString() method to represent the quadratic formula showing the values for a, b and c in the following format:
        //a____x2 + ____b____x + ____c = 0
        //For example, given the values of 1, 3 and -4 for a, b and c respectively, the method should produce
        //1x2 + 3x + -4 = 0
    }
}
