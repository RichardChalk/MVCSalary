using MVCSalary.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCSalaryTests.Services
{
    [TestClass]
    public class SalaryCalculatorTests
    {
        // System Under Test
        private SalaryCalculator sut;
        public SalaryCalculatorTests()
        {
            sut = new SalaryCalculator();
        }

        [TestMethod]
        public void Under30_Should_Get_100kr_Per_Hour()
        {
            // ARRANGE
            var empName = "NOT Richard";
            var empAge = 29;
            var empHours = 10;
            var expected = 1000;

            // ACT
            var result = sut.Calculate(empName, empAge, empHours);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Between30_50_Should_Get_120kr_Per_Hour()
        {
            // ARRANGE
            var empName = "NOT Richard";
            var empAge = 31;
            var empHours = 10;
            var expected = 1200;

            // ACT
            var result = sut.Calculate(empName, empAge, empHours);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Over_50_Should_Get_130kr_Per_Hour()
        {
            // ARRANGE
            var empName = "NOT Richard";
            var empAge = 51;
            var empHours = 10;
            var expected = 1300;

            // ACT
            var result = sut.Calculate(empName, empAge, empHours);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

        [TestMethod]
        public void Under30Richard_Should_Get_110kr_Per_Hour()
        {
            // ARRANGE
            var empName = "Richard";
            var empAge = 29;
            var empHours = 10;
            var expected = 1100;

            // ACT
            var result = sut.Calculate(empName, empAge, empHours);

            // ASSERT
            Assert.AreEqual(expected, result);
        }

    }
}
