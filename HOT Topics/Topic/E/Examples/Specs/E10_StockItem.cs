using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E10_StockItem<TSUT> : ReflectionBase<TSUT>
    {
        //Should calculate the price of the item, to the nearest cent, using the profit margin as a percent (a profit margin of 45 means 45%)
        //Use the rounding where values under a half-cent are rounded down and values greater than or equal to a half-cent are rounded up
        private dynamic New(string itemName, double cost, double profitMargin)
        {
            return NewSUT(itemName, cost, profitMargin);
        }

        [Theory, Trait("Topic E Tests", "StockItem - Example")]
        [InlineData("Computer Mouse")]
        [InlineData("Headphones")]
        public void Should_Get_ItemName(string itemName)
        {
            // Arrange
            var sut = New(itemName, 20.5, 45);

            // Act
            string actual = sut.ItemName;

            // Assert
            Assert.Equal(itemName, actual);
        }

        [Fact, Trait("Topic E Tests", "StockItem - Example")]
        public void Should_Set_ItemName()
        {
            // Arrange
            var expected = "Mouse";
            var sut = New("Speaker", 20.5, 45);

            // Act
            sut.ItemName = expected;

            // Assert
            string actual = sut.ItemName;
            Assert.Equal(expected, actual);
        }

        [Theory, Trait("Topic E Tests", "StockItem - Example")]
        [InlineData(20.5)]
        [InlineData(15.75)]
        public void Should_Get_Cost(double cost)
        {
            // Arrange
            var sut = New("Mouse", cost, 45);

            // Act
            double actual = sut.Cost;

            // Assert
            Assert.Equal(cost, actual);
        }

        [Fact, Trait("Topic E Tests", "StockItem - Example")]
        public void Should_Set_Cost()
        {
            // Arrange
            var expected = 15.75;
            var sut = New("Speaker", 20.5, 45);

            // Act
            sut.Cost = expected;

            // Assert
            double actual = sut.Cost;
            Assert.Equal(expected, actual);
        }

        [Theory, Trait("Topic E Tests", "StockItem - Example")]
        [InlineData(45)]
        [InlineData(102.5)]
        public void Should_Get_ProfitMargin(double profitMargin)
        {
            // Arrange
            var sut = New("Mouse", 20.5, profitMargin);

            // Act
            double actual = sut.ProfitMargin;

            // Assert
            Assert.Equal(profitMargin, actual);
        }

        [Fact, Trait("Topic E Tests", "StockItem - Example")]
        public void Should_Set_ProfitMargin()
        {
            // Arrange
            var expected = 45.2;
            var sut = New("Speaker", 20.5, 105);

            // Act
            sut.ProfitMargin = expected;

            // Assert
            var actual = sut.ProfitMargin;
            Assert.Equal(expected, actual);
        }

        [Theory, Trait("Topic E Tests", "StockItem - Example")]
        [InlineData(-5)]
        [InlineData(45)]
        [InlineData(102.5)]
        public void Should_Calculate_Price(double profitMargin)
        {
            // Arrange
            var givenCost = 20.99;
            var expected = Math.Round(givenCost * (1 + profitMargin / 100.0), 2);

            var sut = New("Mouse", givenCost, profitMargin);

            // Act
            double actual = sut.Price;

            // Assert
            Assert.InRange(actual, expected - 0.01, expected + 0.01);
        }

        [Theory, Trait("Topic E Tests", "StockItem - Example")]
        [InlineData(-5)]
        [InlineData(45)]
        [InlineData(102.5)]
        public void Should_Round_Price(double profitMargin)
        {
            // Arrange
            var givenCost = 20.99;
            var expected = Math.Round(givenCost * (1 + profitMargin / 100.0), 2);

            var sut = New("Mouse", givenCost, profitMargin);

            // Act
            double actual = sut.Price;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
