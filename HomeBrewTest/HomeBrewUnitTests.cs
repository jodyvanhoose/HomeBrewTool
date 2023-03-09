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

        [Fact]
        public void Hop_Display_Says_Flame_Out_When_Time_Is_Zero()
        {
            // Arrange
            var myBeer = new BeerRecipe();
            myBeer.BuildBeerRecipe(myBeer);
            myBeer.DisplayBeerRecipe(myBeer);
            myBeer.IsFlameOut(myBeer);
            myBeer.HopAdditions = 1;
            myBeer.HopTypeArray = new string[myBeer.HopAdditions];
            myBeer.HopWeightArray = new decimal[myBeer.HopAdditions];
            myBeer.HopTimeArray = new int[myBeer.HopAdditions];

            for (int i = 0; i < myBeer.HopAdditions; i++)
            {
                myBeer.HopTypeArray[0] = "Cascade";

                myBeer.HopWeightArray[0] = 1;

                myBeer.HopTimeArray[0] = 0;
            }
            
                
            
            

            // Act
            bool actual = myBeer.IsFlameOut();
            bool expected = true;

            // Assert
            Assert.Equal(expected, actual);
        }
    }
}
