/*
 * Tyrannotea.cs
 * Author: Aidan Smith
 */
 using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class TyrannoteaTest
    {
        [Fact]
        public void CorrectDefaultValues()
        {
            Tyrannotea t = new Tyrannotea();
            Assert.Equal<double>(0.99,t.Price);
            Assert.Equal<uint>(8,t.Calories);
            Assert.Equal<Size>(Size.Small,t.Size);
            Assert.False(t.Sweet);
            Assert.True(t.Ice);
            Assert.False(t.Lemon);
        }
        [Fact]
        public void CorrectChangeToSizeSmall()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Size = Size.Small;
            Assert.Equal<double>(0.99, t.Price);
            Assert.Equal<uint>(8, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeMedium()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Large;
            t.Size = Size.Medium;
            Assert.Equal<double>(1.49, t.Price);
            Assert.Equal<uint>(16, t.Calories);
            Assert.Equal<Size>(Size.Medium, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeLarge()
        {
            Tyrannotea t = new Tyrannotea();
            t.Size = Size.Medium;
            t.Size = Size.Large;
            Assert.Equal<double>(1.99, t.Price);
            Assert.Equal<uint>(32, t.Calories);
            Assert.Equal<Size>(Size.Large, t.Size);
        }
        [Fact]
        public void CanHoldIce()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            Assert.False(t.Ice);
        }
        [Fact]
        public void CanAddLemon()
        {
            Tyrannotea t = new Tyrannotea();
            t.AddLemon();
            Assert.True(t.Lemon);
        }
        [Fact]
        public void SettingSweetGivesCorrectValues()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            Assert.Equal<uint>(16,t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(64, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(32, t.Calories);
            t.Size = Size.Small;
            Assert.Equal<uint>(16, t.Calories);
        }
        [Fact]
        public void ResettingSweetGivesCorrectValues()
        {
            Tyrannotea t = new Tyrannotea();
            t.Sweet = true;
            t.Sweet = false;
            Assert.Equal<uint>(8, t.Calories);
            t.Size = Size.Large;
            Assert.Equal<uint>(32, t.Calories);
            t.Size = Size.Medium;
            Assert.Equal<uint>(16, t.Calories);
            t.Size = Size.Small;
            Assert.Equal<uint>(8, t.Calories);
        }
        [Fact]
        public void CorrectIngredients()
        {
            Tyrannotea t = new Tyrannotea();
            List<string> ingre = t.Ingredients;
            Assert.Contains<string>("Water",ingre);
            Assert.Contains<string>("Tea", ingre);
            Assert.Equal<int>(2, ingre.Count);
            t.Sweet = true;
            ingre = t.Ingredients;
            Assert.Contains<string>("Cane Sugar", ingre);
            Assert.Equal<int>(3, ingre.Count);
            t.Lemon = true;
            ingre = t.Ingredients;
            Assert.Contains<string>("Lemon", ingre);
            Assert.Equal<int>(4, ingre.Count);
        }
    }
}
