using System;
using Xunit;

namespace Algorithms.Tests
{
    public class TwoSumTests
    {
        [Theory]
        [InlineData(new[] { 2,7,11,15 }, 9)]
        public void BruteForce(int[] nums, int target)
        {
            int[] actual = TwoSum.BruteForce(nums, target);

            Assert.Equal(new[] { 0, 1}, actual);
        }
    }
}
