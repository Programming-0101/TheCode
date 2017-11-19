using Microsoft.CSharp.RuntimeBinder;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Topic.Specs;
using Xunit;

namespace Topic.D.Examples.Specs
{
    public class D1_Person<TSUT> : ReflectionBase<TSUT>
    {
        protected dynamic New(string first, string last, DateTime dob)
        {
            return NewSUT(first, last, dob);
        }

        #region From earlier topics
        [Theory, Trait("Topic D Tests", "Person - Example")]
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

        [Fact, Trait("Topic D Tests", "Person - Example")]
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

        [Theory, Trait("Topic D Tests", "Person - Example")]
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

        [Fact, Trait("Topic D Tests", "Person - Example")]
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
        #endregion
    }

    public class D2_Account<TSUT> : ReflectionBase<TSUT>
    {
        protected dynamic New(string bankName, int branchNumber, int institutionNumber, int accountNumber, double balance, double overdraftLimit, string accountType)
        {
            return NewSUT(bankName, branchNumber, institutionNumber, accountNumber, balance, overdraftLimit, accountType);
        }

        #region From earlier topics
        //Should get the bank name, branch number, institution number, account number, balance, overdraft limit, and account type
        #region Getters
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
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
        [Fact, Trait("Topic D Tests", "Account - Example")]
        public void Should_Not_Set_BankName()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.BankName = "CitiBank");

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected BankName setter to be private");
        }
        [Fact, Trait("Topic D Tests", "Account - Example")]
        public void Should_Not_Set_BranchNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.BranchNumber = 32100);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected BranchNumber setter to be private");
        }
        [Fact, Trait("Topic D Tests", "Account - Example")]
        public void Should_Not_Set_InstitutionNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.InstitutionNumber = 011);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected InstitutionNumber setter to be private");
        }
        [Fact, Trait("Topic D Tests", "Account - Example")]
        public void Should_Not_Set_AccountNumber()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.AccountNumber = 7654321);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected AccountNumber setter to be private");
        }
        [Fact, Trait("Topic D Tests", "Account - Example")]
        public void Should_Not_Set_Balance()
        {
            // Arrange
            var sut = New("CIBC", 12345, 010, 1234567, 100.0, 200, "Chequing");

            // Act
            var ex = Assert.Throws<RuntimeBinderException>(() => sut.Balance = 1525.0);

            // Assert
            Assert.True(ex.Message.Contains("set accessor is inaccessible"), "Expected Balance setter to be private");
        }
        [Fact, Trait("Topic D Tests", "Account - Example")]
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

    }

    public class D3_Student
    {
//        Get/Set Name
//* Get/Set Gender
//* Get/Set Student Id
//* Get/Set GPA
//* Get/Set Program
//* Get/Set Full-Time
//* Override ToString() to get the student’s ID and name

    }
    public class D4_Employee
    {
//        Get/Set First Name
//        * Get/Set Last Name
//        * Get/Set Gender
//* Get/Set Employment Date
//* Get/Set Salary
//* Get Social Insurance Number
    }

    public class D5_Company
    {
//        Get/Set Name
//* Get/Set City
//* Get/Set Incorporated
//* Get/Set Number of Employees
//* Get/Set Gross Income to Date
//* Get Business Start Date
    }
}
