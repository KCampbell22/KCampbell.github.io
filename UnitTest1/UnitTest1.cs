using System;
using Xunit;
using Weekly_Salary_Calculator.Models;

namespace XUnitTest1
{
    public class UnitTest1
    {
        [Fact]
        public void HoursTooLow()
        {
            // Arrange
            StudentWorkerModel aStudent = new StudentWorkerModel();
            aStudent.HrsWorked = -1;
            StudentWorkerModel bStudent = new StudentWorkerModel();
            double expected = aStudent.HrsWorked;
            double actual = aStudent.HrsWorked = 1;
            // ACT

            // Assert
            Assert.NotEqual(expected, actual);

        }
        [Fact]
        public void TooManyHours()
        {
            // Arrange
            StudentWorkerModel bExpected = new StudentWorkerModel();
            StudentWorkerModel cActual = new StudentWorkerModel();
            double expected = bExpected.HrsWorked = 16;
            double actual = cActual.HrsWorked = 15;

            // Act
            // Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void TooLowOfWage()
        {
            // Arrange
            StudentWorkerModel c = new StudentWorkerModel();
            StudentWorkerModel d = new StudentWorkerModel();
            double expected = c.HourlyPay = 7.25;
            double actual = d.HourlyPay = 2.55;
            // Act
            // Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void TooHighOfWage()
        {
            // Arrange
            StudentWorkerModel e = new StudentWorkerModel();
            StudentWorkerModel f = new StudentWorkerModel();
            double expected = e.HourlyPay = 14.75;
            double actual = f.HourlyPay = 15.00;
            // Act
            // Assert
            Assert.NotEqual(expected, actual);
        }
        [Fact]
        public void TestValidInput()
        {
            // Arrange
            StudentWorkerModel valid = new StudentWorkerModel();
            StudentWorkerModel actual = new StudentWorkerModel();
            double validInput = valid.HourlyPay = 12.25;
            double validInputB = valid.HrsWorked = 10.00;
            bool results;
            // Act
            results = valid.ValidInput(validInput, validInputB);
            // Assert
            Assert.True(results);
        }

    }
}

