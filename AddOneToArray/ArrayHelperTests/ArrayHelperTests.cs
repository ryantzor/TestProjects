using System;
using AddOneToArray;
using Xunit;

namespace ArrayHelperTests
{
    public class UnitTest1
    {
        [Fact]
        public void When_ArrayWithout9_ReturnArrayPlus1()
        {
            //arrange
            var nums = new int[] {1, 2, 5};
            var expected = new int[] {1, 2, 6};

            //act
            var actual = ArrayHelper.AddOneToArray(nums);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ArrayWith9_ReturnArrayPlus1()
        {
            //arrange
            var nums = new int[] {1, 2, 9};
            var expected = new int[] {1, 3, 0};

            //act
            var actual = ArrayHelper.AddOneToArray(nums);

            //assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void When_ArrayIsAll9_ReturnBiggerArrayPlusOne()
        {
            //arrange
            var nums = new int[] {9, 9, 9};
            var expected = new int[] {1, 0, 0, 0};

            //act
            var actual = ArrayHelper.AddOneToArray(nums);

            //assert
            Assert.Equal(expected, actual);
        }

    }
}
