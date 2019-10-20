/*
 * WaterTest.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

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

        [Fact]
        public void IndividualSpecialTest()
        {
            Water noIce = new Water();
            noIce.HoldIce();
            Assert.Contains("Hold Ice", noIce.Special);
            Assert.Single(noIce.Special);
            Water addLemon = new Water();
            addLemon.AddLemon();
            Assert.Contains("Add Lemon", addLemon.Special);
            Assert.Single(addLemon.Special);
        }

        [Fact]
        public void MultipleSpecialTest()
        {
            Water w = new Water();
            w.HoldIce();
            w.AddLemon();
            Assert.Contains("Hold Ice", w.Special);
            Assert.Contains("Add Lemon", w.Special);
            string[] arr = w.Special;
            Assert.Equal<int>(2,arr.Length);
        }
    }
}
