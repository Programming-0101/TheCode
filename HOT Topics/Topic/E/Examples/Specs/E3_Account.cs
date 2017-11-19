using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E3_Account<TSUT> : D.Examples.Specs.D2_Account<TSUT>
    {

        //Should support deposits and withdrawals
        [Fact, Trait("Topic E Tests", "Account - Example")]
        public void Should_Deposit_Amount()
        {
            // Arrange
            var expected = 350.0;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            sut.Deposit(250);

            // Assert
            var actual = sut.Balance;
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Topic E Tests", "Account - Example")]
        public void Should_Withdraw_Amount()
        {
            // Arrange
            var expected = 75.0;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            sut.Withdraw(25);

            // Assert
            var actual = sut.Balance;
            Assert.Equal(expected, actual);
        }
    }
}
