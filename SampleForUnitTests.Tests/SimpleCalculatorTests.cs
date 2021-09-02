using Xunit;

namespace SampleForUnitTests.Tests
{
    public class SimpleCalculatorTests
    {
        [Fact]
        public void GetSum_2_Plus_5_Eq_7()
        {
            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();
            
            //Act
            var result = calculator.GetSum(2, 5);
            
            //Assert
            Assert.Equal(7,result);
        }

        [Fact]
        public void GetSubstruct_5_Min_2_Eq_3()
        {
            //Arrange
            SimpleCalculator calculator = new SimpleCalculator();
            
            //Act
            var result = calculator.GetSubstruct(5, 2);
            
            //Assert
            Assert.Equal(3,result);
        }
    }
}