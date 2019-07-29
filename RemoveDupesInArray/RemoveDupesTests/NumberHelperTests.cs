using System;
using RemoveDupesInArray;
using Xunit;

namespace RemoveDupesTests
{
    public class NumberHelperTests
    {
        [Fact]
        public void When_DistinctArrayCount_ReturnInt()
        {
            // arrange
            var arr = new int[]{1, 1, 1, 3, 3, 5, 5, 8};
            // act
            var result = NumberHelper.RemoveDuplicates(arr);
            // assert
            Assert.Equal(4, result);
        }

        [Fact]
        public void When_ArrayCount1_Return1()
        {
            // arrange
            var arr = new int[] { 1 };
            // act
            var result = NumberHelper.RemoveDuplicates(arr);
            // assert
            Assert.Equal(1, result);
        }

        [Fact]
        public void When_ArrayCount0_Return0()
        {
            // arrange
            var arr = new int[] { };
            // act
            var result = NumberHelper.RemoveDuplicates(arr);
            // assert
            Assert.Equal(0, result);
        }
    }
}
