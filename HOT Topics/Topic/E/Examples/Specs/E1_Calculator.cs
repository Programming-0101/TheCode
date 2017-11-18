using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E1_Calculator<TSUT> : ReflectionBase<TSUT>
    {
        [Theory]
        [Trait("New Tests", "Topic E Calculator Example")]
        [InlineData(4, 3, 7)]
        [InlineData(5, 7, 12)]
        public void Should_Add_Two_Numbers(int first, int second, int expected)
        {
            // Invoke a static method on a type
            var sut = Type.GetType(TypeName, true);
            var actual = sut.GetMethod("Add", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, new object[] { first, second });
            Assert.True(expected.Equals(actual), $"Expected {first} + {second} to be {expected}, but got {actual}");
        }

        [Theory]
        [Trait("New Tests", "Topic E Calculator Example")]
        [InlineData(4, 3, 12)]
        [InlineData(5, 7, 35)]
        public void Should_Multiply_Two_Numbers(int first, int second, int expected)
        {
            var sut = Type.GetType(TypeName, true);
            var actual = sut.GetMethod("Multiply", System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.Static).Invoke(null, new object[] { first, second });
            Assert.True(expected.Equals(actual), $"Expected {first} * {second} to be {expected}, but got {actual}");
        }
    }
}
