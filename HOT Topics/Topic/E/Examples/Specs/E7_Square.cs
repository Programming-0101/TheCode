using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E7_Square<TSUT> : ReflectionBase<TSUT>
    {
        private dynamic New(double side)
        {
            return NewSUT(side);
        }
        //Should get and set the length of the side of the square
        [Fact, Trait("Topic E Tests", "Square - Example")]
        public void Should_Get_Diameter()
        {
            // Arrange
            var expected = 10.0;
            var sut = New(expected);

            // Act
            var actual = sut.Side;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Topic E Tests", "Square - Example")]
        public void Should_Set_Diameter()
        {
            // Arrange
            var expected = 5.0;
            var sut = New(expected * 3);

            // Act
            sut.Side = expected;

            // Assert
            var actual = sut.Side;
            Assert.Equal(expected, actual);
        }
        //Should calculate the area and perimeter
        [Fact, Trait("Topic E Tests", "Square - Example")]
        public void Should_Get_Area()
        {
            // Arrange
            var expected = 25.0;
            var sut = New(5);

            // Act
            var actual = sut.Area;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Topic E Tests", "Square - Example")]
        public void Should_Get_Perimeter()
        {
            // Arrange
            var expected = 28.0;
            var sut = New(7);

            // Act
            var actual = sut.Perimeter;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
