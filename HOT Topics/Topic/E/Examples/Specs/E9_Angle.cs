using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E9_Angle<TSUT> : ReflectionBase<TSUT>
    {
        private dynamic New(double deg)
        {
            return NewSUT(deg);
        }

        //Should get and set the angle's value(in degrees)
        [Fact, Trait("New Tests", "Topic E Angle Example")]
        public void Should_Get_Numerator()
        {
            // Arrange
            var expected = 45.0;
            var sut = New(expected);

            // Act
            var actual = sut.Degrees;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("New Tests", "Topic E Angle Example")]
        public void Should_Set_Numerator()
        {
            // Arrange
            var expected = 60.0;
            var sut = New(expected / 2);

            // Act
            sut.Degrees = expected;

            // Assert
            var actual = sut.Degrees;
            Assert.Equal(expected, actual);
        }
        //Should calculate the equivalent angle in Radians and Grads, using the following formulas:
        //Radians = Degrees* (π / 180)
        [Fact, Trait("New Tests", "Topic E Angle Example")]
        public void Should_Get_Radians()
        {
            // Arrange
            var expected = 45.0 * (Math.PI / 180);
            var sut = New(45.0);

            // Act
            var actual = sut.Radians;

            // Assert
            Assert.Equal(expected, actual);
        }
        //Grads = Radians* (200 / π)
        [Fact, Trait("New Tests", "Topic E Angle Example")]
        public void Should_Get_Grads()
        {
            // Arrange
            var expected = (45.0 * (Math.PI / 180)) * (200 / Math.PI);
            var sut = New(45.0);

            // Act
            var actual = sut.Grads;

            // Assert
            Assert.Equal(expected, actual);
        }
        //Should override the ToString() method to return the angle in degrees, in the following format:
        //The Unicode character for the degrees symbol is '\u00B0'
        [Fact, Trait("New Tests", "Topic E Angle Example")]
        public void Should_Override_ToString()
        {
            // Arrange
            var expected = "45" + '\u00B0';
            var sut = New(45.0);

            // Act
            var actual = sut.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
