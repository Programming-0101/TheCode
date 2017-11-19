using Microsoft.CSharp.RuntimeBinder;
using System;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E2_Person<TSUT> : D.Practice.Specs.D1_Person<TSUT>
    {

        [Fact, Trait("Topic E Tests", "Person - Example")]
        public void Should_Get_BirthDate()
        {
            // Arrange
            var expected = new DateTime(1992, 05, 30);
            var sut = New("John", "Doe", expected);

            // Act
            DateTime actual = sut.BirthDate;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Topic E Tests", "Person - Example")]
        public void Should_Not_Set_BirthDate()
        {
            // Arrange
            var expected = new DateTime(1992, 05, 30);
            dynamic sut = New("John", "Doe", expected);

            // Act
            DateTime actual = sut.BirthDate;

            // Assert
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.BirthDate = actual.AddDays(5));
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected BirthDate setter to be private");
        }

        [Fact, Trait("Topic E Tests", "Person - Example")]
        public void Should_Get_Age()
        {
            // Arrange
            var given = DateTime.Today.AddYears(-18).AddDays(1);
            var expected = DateTime.Today.Year - given.Year - 1;
            var sut = New("John", "Doe", given);

            // Act
            int actual = sut.Age;

            // Assert
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Topic E Tests", "Person - Example")]
        public void Should_Get_Initials()
        {
            // Arrange
            var expected = "O.K.";
            var sut = New("Oliver", "Krandish", new DateTime(1992, 05, 30));

            // Act
            string actual = sut.Initials;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
