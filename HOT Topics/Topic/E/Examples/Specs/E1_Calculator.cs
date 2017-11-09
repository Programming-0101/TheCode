using System;
using System.Linq;
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
}
