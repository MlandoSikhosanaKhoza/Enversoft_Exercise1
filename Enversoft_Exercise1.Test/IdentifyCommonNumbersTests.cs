using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enversoft_Exercise1.Test
{
    public class IdentifyCommonNumbersTests
    {
        private IdentifyCommonNumbers _identifyCommonNumbers;
        public IdentifyCommonNumbersTests() {
            _identifyCommonNumbers = new IdentifyCommonNumbers();
        }
        /// <summary>
        /// a. Show the common elements in both lists. E.g the common elements are "3 4 5", because they are contained in both lists.
        /// 
        /// I'm really trying to stand out here
        /// 
        /// </summary>
        /// <param name="list1"></param>
        /// <param name="list2"></param>
        /// <param name="expected"></param>
        [Theory]
        [InlineData(new int[] { 1,2,3,4,5 }, new int[] { 3,4,5,6,7 }, new int[] { 3,4,5 })]
        [InlineData(new int[] { 3,6,9,12 }, new int[] { 6,12,18 }, new int[] { 6,12 })]
        public void IdentifyCommonNumbers_GetCommonNumbers_ReturnsIntArray(int[] list1, int[] list2, int[] expected)
        {
            //Arrange
            int[] result;
            /* There aren't any mocks for this one */
            //Act
            result = _identifyCommonNumbers.GetCommonNumbers(list1, list2);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
