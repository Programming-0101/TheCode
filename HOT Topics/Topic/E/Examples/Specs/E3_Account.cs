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
    public abstract class E3_Account : ReflectionBase
    {
        private dynamic New(string bankName, int branchNumber, int institutionNumber, int accountNumber, double balance, double overdraftLimit, string accountType)
        {
            return NewSUT(bankName,branchNumber,institutionNumber, accountNumber, balance, overdraftLimit, accountType);
        }

        #region From earlier topics
        //Should get the bank name, branch number, institution number, account number, balance, overdraft limit, and account type
        #region Getters
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_BankName()
        {
            // Arrange
            var expected = "CIBC";
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.BankName;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_BranchNumber()
        {
            // Arrange
            var expected = 12345;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.BranchNumber;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_InstitutionNumber()
        {
            // Arrange
            var expected = 010;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.InstitutionNumber;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_AccountNumber()
        {
            // Arrange
            var expected = 1234567;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.AccountNumber;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_Balance ()
        {
            // Arrange
            var expected = 100.0;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.Balance;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_OverdraftLimit()
        {
            // Arrange
            var expected = 200.0;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var actual = sut.OverdraftLimit;

            // Assert
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Get_AccountType()
        {
            // Arrange
            var expected = "Chequing";
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            string actual = sut.AccountType;

            // Assert
            Assert.Equal(expected, actual);
        }
        #endregion

        //Should allow the overdraft limit to be set
        #region Setters
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Set_OverdraftLimit()
        {
            // Arrange
            var expected = 250.0;
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            sut.OverdraftLimit = expected;

            // Assert
            var actual = sut.OverdraftLimit;
            Assert.Equal(expected, actual);
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_BankName()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.BankName = "CitiBank");

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected BankName setter to be private");
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_BranchNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.BranchNumber = 32100);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected BranchNumber setter to be private");
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_InstitutionNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.InstitutionNumber = 011);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected InstitutionNumber setter to be private");
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_AccountNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.AccountNumber = 7654321);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected AccountNumber setter to be private");
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_Balance()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Balance = 1525.0);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected Balance setter to be private");
        }
        [Fact, Trait("Prior Tests", "Topic E Account Example")]
        public void Should_Not_Set_AccountType()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.AccountType = "Savings");

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected AccountType setter to be private");
        }
        #endregion
        #endregion

        // NEW
        //Should support deposits and withdrawals
        [Fact, Trait("New Tests", "Topic E Account Example")]
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
        [Fact, Trait("New Tests", "Topic E Account Example")]
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
    public abstract class E4_ElapsedTime : ReflectionBase
    {
        //Should calculate the hours, minutes and seconds given the total seconds
        //Should calculate the total seconds given the hours, minutes and seconds
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
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
        #endregion
    }
    public abstract class E5_ResolveExpressions : ReflectionBase
    {
        //10.0 + 15 / 2 + 4.3
        //8 / 5 + 1.25
        //10.0 + 15.0 / 2 + 4.3
        //3.0 * 4 / 6 + 6
        //3.0 * (4 % 6) + 6
        //3 * 4.0 / 6 + 6
        //20.0 - 2 / 6 + 3
        //10 + 17 % 3 + 4
        //(10 + 17) % 3 +4.0
        //10 + 17 / 4.0 + 4
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
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
        #endregion
    }
    public abstract class E10_StockItem : ReflectionBase
    {
        //Should get and set the name, cost and profit margin of the stock item
        //Should represent the profit margin as a percent; a value of 45 means 45%
        //Should calculate the price of the item, to the nearest cent
        //Use the rounding where values under a half-cent are rounded down and values greater than or equal to a half-cent are rounded up
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
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
        #endregion
    }
    public abstract class E11_Die : ReflectionBase
    {
        // TODO: Need to figure out a way to test "random numbers"....
        private dynamic New(int numerator, int denominator)
        {
            return NewSUT(numerator, denominator);
        }
        //Should get the numerator/denominator
        [Fact, Trait("New Tests", "Topic E Die Example")]
        public void Should_Get_Numerator()
        {
            throw new NotImplementedException();
            // Arrange
            var expected = 8;
            var sut = New(8, 4);

            // Act
            var actual = sut.Numerator;

            // Assert
            Assert.Equal(expected, actual);
        }

        //Should generate a random value from 1 to 6, when initially created and when re-rolled
        //Should get the face value of the die
    }
    public abstract class E12_ParkingCounter : ReflectionBase
    {
        //Should track vehicles entering
        //Should track vehicles leaving
        //Should get total parking spots
        //Should get open(empty) spots
        //Should reset lot as full(that is, fill the parking lot)
        //Should reset lot as empty(that is, clear all the parking spots of vehicles)
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
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
        #endregion
    }
    public abstract class E13_QuadraticEquation : ReflectionBase
    {
        //Should get the lower root, using the quadratic formula
        //x = (-b -√(b^2-4ac))/2a$
        //Should get the higher root, using the quadratic formula
        //x = (-b +√(b^2-4ac))/2a$
        //Should overload the ToString() method to represent the quadratic formula showing the values for a, b and c in the following format:
        //a____x2 + ____b____x + ____c = 0
        //For example, given the values of 1, 3 and -4 for a, b and c respectively, the method should produce
        //1x2 + 3x + -4 = 0
        private dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
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
        #endregion
    }
}
