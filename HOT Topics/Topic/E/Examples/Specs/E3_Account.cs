using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Linq;
using Topic.Specs;
using Xunit;

namespace Topic.E.Examples.Specs
{
    public abstract class E3_Account<TSUT> : ReflectionBase<TSUT>
    {
        private dynamic New(string bankName, int branchNumber, int institutionNumber, int accountNumber, double balance, double overdraftLimit, string accountType)
        {
            return NewSUT(bankName, branchNumber, institutionNumber, accountNumber, balance, overdraftLimit, accountType);
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
        public void Should_Get_Balance()
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
}
