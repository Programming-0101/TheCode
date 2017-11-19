using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E6_Circle<TSUT> : ReflectionBase<TSUT>
    {
        private dynamic New(double diameter)
        {
            return NewSUT(diameter);
        }
        //Should get and set the diameter
        [Fact, Trait("Topic E Tests", "Circle - Example")]
        public void Should_Get_Diameter()
        {
            // Arrange
            var expected = 10.0;
            var sut = New(expected);

            // Act
            var actual = sut.Diameter;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Topic E Tests", "Circle - Example")]
        public void Should_Set_Diameter()
        {
            // Arrange
            var expected = 12.0;
            var sut = New(10);

            // Act
            sut.Diameter = expected;

            // Assert
            var actual = sut.Diameter;
            Assert.Equal(expected, actual);
        }

        //Should calculate the area, radius, and circumference
        [Fact, Trait("Topic E Tests", "Circle - Example")]
        public void Should_Get_Circumference()
        {
            // Arrange
            var expected = 10 * Math.PI;
            var sut = New(10);

            // Act
            var actual = sut.Circumference;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Topic E Tests", "Circle - Example")]
        public void Should_Get_Area()
        {
            // Arrange
            var expected = Math.PI * 100 * 100;
            var sut = New(200);

            // Act
            var actual = sut.Area;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Topic E Tests", "Circle - Example")]
        public void Should_Get_Radius()
        {
            // Arrange
            var expected = 25.0;
            var sut = New(50);

            // Act
            var actual = sut.Radius;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
