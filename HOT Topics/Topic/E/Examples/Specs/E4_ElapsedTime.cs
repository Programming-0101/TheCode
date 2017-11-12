using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E4_ElapsedTime : ReflectionBase
    {
        private dynamic New(int hours, int minutes, int seconds)
        {
            return NewSUT(hours, minutes, seconds);
        }

        private dynamic New(int totalSeconds)
        {
            return NewSUT(totalSeconds);
        }

        #region Construction Tests
        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Construct_From_Hours_Minutes_Seconds_And_Get_Same()
        {
            // Arrange
            var expectedHours = 2;
            var expectedMinutes = 45;
            var expectedSeconds = 20;

            // Act
            var sut = New(expectedHours, expectedMinutes, expectedSeconds);

            // Assert
            Assert.True(expectedHours.Equals(sut.Hours), $"Expected the hours to be {expectedHours} but got {sut.Hours}");
            Assert.True(expectedMinutes.Equals(sut.Minutes), $"Expected the minutes to be {expectedMinutes} but got {sut.Minutes}");
            Assert.True(expectedSeconds.Equals(sut.Seconds), $"Expected the seconds to be {expectedSeconds} but got {sut.Seconds}");
        }

        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Construct_From_TotalSeconds()
        {
            // Arrange
            var givenHours = 2;
            var givenMinutes = 45;
            var givenSeconds = 20;
            var expectedTotalSeconds = givenSeconds + givenMinutes * 60 + givenHours * 60 * 60;

            // Act
            var sut = New(expectedTotalSeconds);

            // Assert
            Assert.True(expectedTotalSeconds.Equals(sut.TotalSeconds), $"Expected the Total Seconds to be {expectedTotalSeconds} but got {sut.TotalSeconds}");
        }
        #endregion

        #region Conversion Tests
        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Get_TotalSeconds_From_Hours_Minutes_Seconds()
        {
            // Arrange
            var givenHours = 2;
            var givenMinutes = 45;
            var givenSeconds = 20;
            var expectedTotalSeconds = givenSeconds + givenMinutes * 60 + givenHours * 60 * 60;

            // Act
            var sut = New(givenHours, givenMinutes, givenSeconds);

            // Assert
            Assert.True(expectedTotalSeconds.Equals(sut.TotalSeconds), $"Expected the Total Seconds to be {expectedTotalSeconds} but got {sut.TotalSeconds}");
        }

        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Get_Hours_Portion_From_TotalSeconds()
        {
            // Arrange
            var expectedHours = 2;
            var expectedMinutes = 45;
            var expectedSeconds = 20;
            var givenTotalSeconds = expectedSeconds + expectedMinutes * 60 + expectedHours * 60 * 60;

            // Act
            var sut = New(givenTotalSeconds);

            // Assert
            Assert.True(expectedHours.Equals(sut.Hours), $"Expected the hours to be {expectedHours} but got {sut.Hours}");
        }

        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Get_Minutes_Portion_From_TotalSeconds()
        {
            // Arrange
            var expectedHours = 2;
            var expectedMinutes = 45;
            var expectedSeconds = 20;
            var givenTotalSeconds = expectedSeconds + expectedMinutes * 60 + expectedHours * 60 * 60;

            // Act
            var sut = New(givenTotalSeconds);

            // Assert
            Assert.True(expectedMinutes.Equals(sut.Minutes), $"Expected the minutes to be {expectedMinutes} but got {sut.Minutes}");
        }

        [Fact, Trait("New Tests", "Topic E ElapsedTime Example")]
        public void Should_Get_Seconds_Portion_From_TotalSeconds()
        {
            // Arrange
            var expectedHours = 2;
            var expectedMinutes = 45;
            var expectedSeconds = 20;
            var givenTotalSeconds = expectedSeconds + expectedMinutes * 60 + expectedHours * 60 * 60;

            // Act
            var sut = New(givenTotalSeconds);

            // Assert
            Assert.True(expectedSeconds.Equals(sut.Seconds), $"Expected the seconds to be {expectedSeconds} but got {sut.Seconds}");
        }
        #endregion

        #region Setters
        [Fact, Trait("New Tests", "Topic E Elapsed Example")]
        public void Should_Not_Set_Hours()
        {
            // Arrange
            var sut = New(5, 20, 45);

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Hours = 3);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected Hours setter to be private");
        }
        [Fact, Trait("New Tests", "Topic E Elapsed Example")]
        public void Should_Not_Set_Minutes()
        {
            // Arrange
            var sut = New(5, 20, 45);

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Minutes = 59);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected Minutes setter to be private");
        }
        [Fact, Trait("New Tests", "Topic E Elapsed Example")]
        public void Should_Not_Set_Seconds()
        {
            // Arrange
            var sut = New(5, 20, 45);

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Seconds = 7);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected Seconds setter to be private");
        }
        [Fact, Trait("New Tests", "Topic E Elapsed Example")]
        public void Should_Not_Set_TotalSeconds()
        {
            // Arrange
            var sut = New(4525);

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.TotalSeconds = 4700);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected TotalSeconds setter to be private");
        }
        #endregion
    }
}
