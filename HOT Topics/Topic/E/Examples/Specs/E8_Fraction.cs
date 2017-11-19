using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E8_Fraction<TSUT> : ReflectionBase<TSUT>
    {
        private dynamic New(int numerator, int denominator)
        {
            return NewSUT(numerator, denominator);
        }
        #region Prior Tests
        //Should get the numerator/denominator
        [Fact, Trait("Prior Tests", "Fraction - Example")]
        public void Should_Get_Numerator()
        {
            // Arrange
            var expected = 8;
            var sut = New(8, 4);

            // Act
            var actual = sut.Numerator;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Fraction - Example")]
        public void Should_Get_Denominator()
        {
            // Arrange
            var expected = 5;
            var sut = New(10, 5);

            // Act
            var actual = sut.Denominator;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Fraction - Example")]
        public void Should_Not_Set_Numerator()
        {
            // Arrange
            var expected = 8;
            var sut = New(8, 4);

            // Act
            var actual = sut.Numerator;

            // Assert
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Numerator = 12);
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected numerator setter to be private");
        }
        [Fact, Trait("Prior Tests", "Fraction - Example")]
        public void Should_Not_Set_Denominator()
        {
            // Arrange
            var expected = 5;
            var sut = New(10, 5);

            // Act
            var actual = sut.Denominator;

            // Assert
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Denominator = 10);
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected denominator setter to be private");
        }
        #endregion

        //Should get the string representation of the fraction, as “numerator/denominator”
        [Fact, Trait("Topic E Tests", "Fraction - Example")]
        public void Should_Get_Fraction_As_String()
        {
            // Arrange
            var expected = "8/4";
            var sut = New(8, 4);

            // Act
            var actual = sut.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
        //Should get the numeric value of the fraction(as a real number)
        [Fact, Trait("Topic E Tests", "Fraction - Example")]
        public void Should_Get_Double_Value()
        {
            // Arrange
            var expected = 8 / 4;
            var sut = New(8, 4);

            // Act
            var actual = sut.ToDouble();

            // Assert
            Assert.Equal(expected, actual);
        }
        //Should get the reciprocal of the fraction
        [Fact, Trait("Topic E Tests", "Fraction - Example")]
        public void Should_Get_Reciprocal()
        {
            // Arrange
            var expectedNumerator = 4;
            var expectedDenominator = 8;
            var sut = New(8, 4);

            // Act
            var actual = sut.Reciprocal;

            // Assert
            Assert.Equal(expectedNumerator, actual.Numerator);
            Assert.Equal(expectedDenominator, actual.Denominator);
        }
    }
}
