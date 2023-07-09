using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enversoft_Exercise1.Test
{
    public class IdentifyUncommonNumbersTest
    {
        private readonly IdentifyUncommonNumbers _identifyUncommonNumbers;
        public IdentifyUncommonNumbersTest() { 
            _identifyUncommonNumbers = new IdentifyUncommonNumbers();
        }
        [Theory]
        [InlineData(new int[] { 1, 2, 3, 4, 5 }, new int[] { 3, 4, 5, 6, 7 }, new int[] { 1, 2 })]
        [InlineData(new int[] { 3, 4, 5, 6, 7 }, new int[] { 1, 2, 3, 4, 5 }, new int[] { 6, 7 })]
        public void IdentifyUncommonNumbers_GetUncommonNumbersFromPrimaryList_ReturnsIntArray(int[] primaryListNumbers, int[] secondaryListNumbers, int[] expected)
        {
            //Arrange
            int[] result;
            //Act
            result = _identifyUncommonNumbers.GetUncommonNumbersFromPrimaryList(primaryListNumbers, secondaryListNumbers);
            //Assert
            Assert.Equal(expected, result);
        }
    }
}
