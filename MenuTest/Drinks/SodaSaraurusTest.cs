using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class SodaSaraurusTest
    {
        // The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            SodaSaraurus soda = new SodaSaraurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        // The correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            SodaSaraurus soda = new SodaSaraurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        // The correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            SodaSaraurus soda = new SodaSaraurus();
            Assert.True(soda.Ice);
        }
        // The correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            SodaSaraurus soda = new SodaSaraurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        // correct calories after setting small
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            SodaSaraurus soda = new SodaSaraurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        // correct price after setting small

        // correct calories after setting medium
        // correct price after setting medium

        // correct calories after setting large
        // correct price after setting large

        // testing ice property
    }
}
