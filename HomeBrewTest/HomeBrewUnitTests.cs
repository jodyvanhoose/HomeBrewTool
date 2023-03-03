using System;
using Xunit;
using HomeBrew;

namespace HomeBrewTest
{
    public class HomeBrewUnitTests
    {
        [Fact]
        public void ABV_Calculates_Correctly()
        {
            //Arrange
            AbvCalculator abv = new AbvCalculator();


            //Act
            var actual = abv.CalculateABV(1.042, 1.005).ToString("0.0");
            var actual2 = abv.CalculateABV(1.058, 1.010).ToString("0.0");


            //Assert
            Assert.Equal("4.9", actual);
            Assert.Equal("6.3", actual2);
        }
        
        [Fact]
        public void Brix_Converts_To_Specfic_Gravity_Test()
        {
            // Arrange
            BrixConverter brix = new BrixConverter();

            // Act
            string actual = brix.BrixToSpecficGravity(11).ToString("0.000");


            // Assert
            Assert.Equal("1.044", actual);
        }
    }
}
