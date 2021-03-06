﻿using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E5_ResolveExpressions<TSUT> : ReflectionBase<TSUT>
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
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
        }

        #region From earlier topics
        [Theory, Trait("Prior Tests", "Person - Example")]
        [InlineData("John")]
        [InlineData("Jane")]
        public void Should_Get_FirstName(string firstName)
        {
            // Arrange
            var sut = New(firstName, "Doe", new DateTime(1990, 05, 30));

            // Act
            string actual = sut.FirstName;

            // Assert
            Assert.Equal(firstName, actual);
        }
        #endregion
    }
    public abstract class E11_Die<TSUT> : ReflectionBase<TSUT>
    {
        // TODO: Need to figure out a way to test "random numbers"....
        private dynamic New(int numerator, int denominator)
        {
            return NewSUT(numerator, denominator);
        }
        //Should get the numerator/denominator
        [Fact, Trait("Topic E Tests", "Die - Example")]
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
    public abstract class E12_ParkingCounter<TSUT> : ReflectionBase<TSUT>
    {
        //Should track vehicles entering
        //Should track vehicles leaving
        //Should get total parking spots
        //Should get open(empty) spots
        //Should reset lot as full(that is, fill the parking lot)
        //Should reset lot as empty(that is, clear all the parking spots of vehicles)
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
        }

        #region From earlier topics
        [Theory, Trait("Prior Tests", "Person - Example")]
        [InlineData("John")]
        [InlineData("Jane")]
        public void Should_Get_FirstName(string firstName)
        {
            // Arrange
            var sut = New(firstName, "Doe", new DateTime(1990, 05, 30));

            // Act
            string actual = sut.FirstName;

            // Assert
            Assert.Equal(firstName, actual);
        }
        #endregion
    }
    public abstract class E13_QuadraticEquation<TSUT> : ReflectionBase<TSUT>
    {
        //Should get the lower root, using the quadratic formula
        //x = (-b -√(b^2-4ac))/2a$
        //Should get the higher root, using the quadratic formula
        //x = (-b +√(b^2-4ac))/2a$
        //Should overload the ToString() method to represent the quadratic formula showing the values for a, b and c in the following format:
        //a____x2 + ____b____x + ____c = 0
        //For example, given the values of 1, 3 and -4 for a, b and c respectively, the method should produce
        //1x2 + 3x + -4 = 0
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
        }

        #region From earlier topics
        [Theory, Trait("Prior Tests", "Person - Example")]
        [InlineData("John")]
        [InlineData("Jane")]
        public void Should_Get_FirstName(string firstName)
        {
            // Arrange
            var sut = New(firstName, "Doe", new DateTime(1990, 05, 30));

            // Act
            string actual = sut.FirstName;

            // Assert
            Assert.Equal(firstName, actual);
        }
        #endregion
    }
}
