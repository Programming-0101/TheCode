using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace Topic.D.Practice.Specs
{
    public class D1_Person<TSUT> : Examples.Specs.D1_Person<TSUT>
    {
        [Fact, Trait("Topic D Tests", "Person - Practice")]
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
    }
}
