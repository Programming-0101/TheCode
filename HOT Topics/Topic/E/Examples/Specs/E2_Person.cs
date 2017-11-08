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
    public abstract class E1_Calculator : ReflectionBase
    {
        [Fact]
        [Trait("New Tests", "Topic E Calculator Example")]
        public void Should_Add_Two_Numbers()
        {
            // Invoke a static method on a type
            var sut = Type.GetType(TypeName, true);
            var actual = sut.GetMethod("Add", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, new object[] { 5, 7 });
            Assert.Equal(12, actual);
        }

        [Fact]
        [Trait("New Tests", "Topic E Calculator Example")]
        public void Should_Multiply_Two_Numbers()
        {
            var sut = Type.GetType("Topic.E.Examples.Calculator,Topic.xUnit.Specs", true);
            var actual = sut.GetMethod("Multiply", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, new object[] { 4, 3 });
            Assert.Equal(12, actual);
        }
    }
    public class E3_Account    {    }
    public class E4_ElapsedTime { }
    public class E5_ResolveExpressions { }
    public class E6_Circle { }
    public class E7_Square { }
    public class E8_Fraction { }
    public class E9_Angle { }
    public class E10_StockTime { }
    public class E11_Die { }
    public class E12_ParkingCounter { }
    public class E13_QuadraticEquation { }
    public class E2_Person
    {
        private Person New(string first, string last, DateTime dob)
        {
            return new Person(first, last, dob);
        }

        #region From earlier topics
        [Theory, Trait("Prior Tests", "Topic E Person Example")]
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

        [Fact, Trait("Prior Tests", "Topic E Person Example")]
        public void Should_Set_FirstName()
        {
            // Arrange
            var expected = "Sam";
            var sut = New("John", "Doe", new DateTime(1990, 05, 30));

            // Act
            sut.FirstName = expected;

            // Assert
            string actual = sut.FirstName;
            Assert.Equal(expected, actual);
        }

        [Theory, Trait("Prior Tests", "Topic E Person Example")]
        [InlineData("Doe")]
        [InlineData("Deer")]
        public void Should_Get_LastName(string lastName)
        {
            // Arrange
            var sut = New("John", lastName, new DateTime(1990, 05, 30));

            // Act
            string actual = sut.LastName;

            // Assert
            Assert.Equal(lastName, actual);
        }

        [Fact, Trait("Prior Tests", "Topic E Person Example")]
        public void Should_Set_LastName()
        {
            // Arrange
            var expected = "Gilford";
            var sut = New("John", "Doe", new DateTime(1990, 05, 30));

            // Act
            sut.LastName = expected;

            // Assert
            string actual = sut.LastName;
            Assert.Equal(expected, actual);
        }

        [Fact, Trait("Prior Tests", "Topic E Person Example")]
        public void Should_Override_ToString()
        {
            // Arrange
            var expected = "John Van Gohe";
            var sut = New("John", "Van Gohe", new DateTime(1990, 05, 30));

            // Act
            string actual = sut.ToString();

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        [Fact, Trait("New Tests", "Topic E Person Example")]
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

        [Fact, Trait("New Tests", "Topic E Person Example")]
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

        [Fact, Trait("New Tests", "Topic E Person Example")]
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

        [Fact, Trait("New Tests", "Topic E Person Example")]
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
