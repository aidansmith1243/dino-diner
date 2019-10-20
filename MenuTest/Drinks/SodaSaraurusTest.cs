/*
 * SodaSaraurus.cs
 * Author: Aidan Smith
 */
 using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class SodasaurusTest
    {
        // The correct default calories
        [Fact]
        public void HasCorrectDefaultCalories()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<uint>(112, soda.Calories);
        }
        // The correct default price
        [Fact]
        public void HasCorrectDefaultPrice()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<double>(1.50, soda.Price);
        }
        // The correct default ice
        [Fact]
        public void HasCorrectDefaultIce()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.True(soda.Ice);
        }
        // The correct default size
        [Fact]
        public void HasCorrectDefaultSize()
        {
            Sodasaurus soda = new Sodasaurus();
            Assert.Equal<Size>(Size.Small, soda.Size);
        }

        [Fact]
        public void HasCorrectMediumSize()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            Assert.Equal<Size>(Size.Medium, soda.Size);
        }
        [Fact]
        public void HasCorrectLargeSize()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            Assert.Equal<Size>(Size.Large, soda.Size);
        }
        // correct calories after setting small
        [Fact]
        public void CorrectCaloriesAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal<uint>(112, soda.Calories);
        }
        // correct price after setting small
        [Fact]
        public void CorrectPriceAfterSettingSmall()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Small;
            Assert.Equal<double>(1.5, soda.Price);
        }
        // correct calories after setting medium
        [Fact]
        public void CorrectCaloriesAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Medium;
            Assert.Equal<uint>(156, soda.Calories);
        }
        // correct price after setting medium
        [Fact]
        public void CorrectPriceAfterSettingMedium()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Large;
            soda.Size = Size.Medium;
            Assert.Equal<double>(2.00, soda.Price);
        }
        // correct calories after setting large
        [Fact]
        public void CorrectCaloriesAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<uint>(208, soda.Calories);
        }
        // correct price after setting large
        [Fact]
        public void CorrectPriceAfterSettingLarge()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Size = Size.Medium;
            soda.Size = Size.Large;
            Assert.Equal<double>(2.50, soda.Price);
        }

        // testing ice property
        [Fact]
        public void CorrectIce()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.HoldIce();
            Assert.False(soda.Ice);
        }
        //Test the ingredients
        [Fact]
        public void CorrectIngredients()
        {
            Sodasaurus soda = new Sodasaurus();
            List<string> ingre = soda.Ingredients;
            Assert.Contains<string>("Water",ingre);
            Assert.Contains<string>("Natural Flavors", ingre);
            Assert.Contains<string>("Cane Sugar", ingre);
            Assert.Equal<int>(3,ingre.Count);
        }
        [Fact]
        public void CorrectFlavor()
        {
            Sodasaurus soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cherry;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cherry, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Chocolate;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Chocolate, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Cola;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Cola, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Lime;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Lime, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Orange;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Orange, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.RootBeer;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.RootBeer, soda.Flavor);

            soda = new Sodasaurus();
            soda.Flavor = SodasaurusFlavor.Vanilla;
            Assert.Equal<SodasaurusFlavor>(SodasaurusFlavor.Vanilla, soda.Flavor);
        }

        [Fact]
        public void SpecialTest()
        {
            Sodasaurus s = new Sodasaurus();
            s.HoldIce();
            Assert.Contains("Hold Ice", s.Special);
            Assert.Single(s.Special);
        }
    }
}
