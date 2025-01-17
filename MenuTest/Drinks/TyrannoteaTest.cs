﻿/*
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

        [Fact]
        public void IndividualSpecialTest()
        {
            Tyrannotea addLemon = new Tyrannotea();
            addLemon.AddLemon();
            Assert.Contains("Add Lemon", addLemon.Special);
            Assert.Single(addLemon.Special);
            Tyrannotea noIce = new Tyrannotea();
            noIce.HoldIce();
            Assert.Contains("Hold Ice", noIce.Special);
            Assert.Single(noIce.Special);
        }

        [Fact]
        public void MultipleSpecialTest()
        {
            Tyrannotea t = new Tyrannotea();
            t.HoldIce();
            t.AddLemon();
            Assert.Contains("Add Lemon", t.Special);
            Assert.Contains("Hold Ice", t.Special);
            string[] arr = t.Special;
            Assert.Equal<int>(2,arr.Length);
        }
        [Theory]
        [InlineData("Special")]
        public void HoldingItemsShouldNotifyOfPropertyChange(string s)
        {
            Tyrannotea dn = new Tyrannotea();
            Assert.PropertyChanged(dn, s, () => { dn.HoldIce(); });
            Assert.PropertyChanged(dn, s, () => { dn.AddLemon(); });
        }
        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        [InlineData("Description")]
        public void MakingSweetShouldNotifyOfPropertyChange(string s)
        {
            Tyrannotea dn = new Tyrannotea();
            Assert.PropertyChanged(dn, s, () => { dn.Sweet = true; });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Size")]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void ChangingSizeShouldNotifyOfPropertyChange(string s)
        {
            Tyrannotea w = new Tyrannotea();

            Assert.PropertyChanged(w, s, () => { w.Size = Size.Medium; });
            Assert.PropertyChanged(w, s, () => { w.Size = Size.Large; });
            Assert.PropertyChanged(w, s, () => { w.Size = Size.Small; });
        }
    }
}
