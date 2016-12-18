using Microsoft.VisualStudio.TestTools.UnitTesting;
using TwoSum;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwoSum.Tests
{
    [TestClass()]
    public class TwoSumTests
    {
        [TestMethod()]
        public void NullTest()
        {
            //Arrange
            int[] nums = { };
            var TwoSum = 0;

            //Act
            var target = new TwoSumSolution();
            var expected = target.TwoSum(nums, TwoSum);

            //Assert
            int[] actual = new int[2];
            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void NoTwoSumTest()
        {
            //Arrange
            int[] nums = { 1, 2, 3, 4, 5 };
            var TwoSum = 12;

            //Act
            var target = new TwoSumSolution();
            var expected = target.TwoSum(nums, TwoSum);

            //Assert
            int[] actual = new int[2];
            CollectionAssert.AreEqual(expected, actual);
        }
        
        [TestMethod()]
        public void TwoSumTest()
        {
            //Arrange
            int[] nums = { 2, 7, 11, 15 };
            var TwoSum = 26;

            //Act
            var target = new TwoSumSolution();
            var expected = target.TwoSum(nums, TwoSum);

            //Assert
            int[] actual = new int[2]{ 2, 3};
            CollectionAssert.AreEqual(expected, actual);
        }
    }
}