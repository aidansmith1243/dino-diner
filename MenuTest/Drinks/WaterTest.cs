/*
 * WaterTest.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

namespace MenuTest.Drinks
{
    public class WaterTest
    {
        [Fact]
        public void CorrectDefaultValues()
        {
            Water t = new Water();
            Assert.Equal<double>(0.1, t.Price);
            Assert.Equal<uint>(0, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
            Assert.True(t.Ice);

        }
        [Fact]
        public void CorrectChangeToSizeSmall()
        {
            Water t = new Water();
            t.Size = Size.Large;
            t.Size = Size.Small;
            Assert.Equal<double>(0.1, t.Price);
            Assert.Equal<uint>(0, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeMedium()
        {
            Water t = new Water();
            t.Size = Size.Large;
            t.Size = Size.Medium;
            Assert.Equal<double>(0.1, t.Price);
            Assert.Equal<uint>(0, t.Calories);
            Assert.Equal<Size>(Size.Medium, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeLarge()
        {
            Water t = new Water();
            t.Size = Size.Medium;
            t.Size = Size.Large;
            Assert.Equal<double>(0.1, t.Price);
            Assert.Equal<uint>(0, t.Calories);
            Assert.Equal<Size>(Size.Large, t.Size);
        }
        [Fact]
        public void CanHoldIce()
        {
            Water t = new Water();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        [Fact]
        public void CanAddLemon()
        {
            Water t = new Water();
            t.AddLemon();
            Assert.True(t.Lemon);
        }
        [Fact]
        public void CorrectIngredients()
        {
            Water t = new Water();
            List<string> ingre = t.Ingredients;
            Assert.Contains<string>("Water", ingre);
            int len = ingre.Count;
            Assert.Equal<int>(1, len);
            t.Lemon = true;
            ingre = t.Ingredients;
            Assert.Contains<string>("Lemon", ingre);
            Assert.Equal<int>(2, ingre.Count);
        }
    }
}
