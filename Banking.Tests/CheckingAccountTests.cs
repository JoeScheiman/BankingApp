using System;
using Xunit;

namespace Banking.Tests
{
    public class CheckingAccountTests
    {
        [Fact]
        public void Balance_Starts_At_Zero()
        {
            // Act
            CheckingAccount account = new CheckingAccount();

            // Assert
            Assert.Equal(0M, account.Balance);

        }

        [Fact]
        public void Deposit_Increase_Balance()
        {
            // Arrange
            CheckingAccount account = new CheckingAccount();

            // Act
            account.Deposit(200M);

            // Assert
            Assert.Equal(200M, account.Balance);
        }
    }
}
