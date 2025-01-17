﻿/*
 * JurassicJavaTest.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Drinks
{
    public class JurassicJavaTest
    {
        [Fact]
        public void CorrectDefaultValues()
        {
            JurassicJava t = new JurassicJava();
            Assert.Equal<double>(0.59, t.Price);
            Assert.Equal<uint>(2, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
            Assert.False(t.Ice);
            Assert.False(t.Decaf);
            Assert.False(t.RoomForCream);
        }
        [Fact]
        public void CorrectChangeToSizeSmall()
        {
            JurassicJava t = new JurassicJava();
            t.Size = Size.Large;
            t.Size = Size.Small;
            Assert.Equal<double>(0.59, t.Price);
            Assert.Equal<uint>(2, t.Calories);
            Assert.Equal<Size>(Size.Small, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeMedium()
        {
            JurassicJava t = new JurassicJava();
            t.Size = Size.Large;
            t.Size = Size.Medium;
            Assert.Equal<double>(0.99, t.Price);
            Assert.Equal<uint>(4, t.Calories);
            Assert.Equal<Size>(Size.Medium, t.Size);
        }
        [Fact]
        public void CorrectChangeToSizeLarge()
        {
            JurassicJava t = new JurassicJava();
            t.Size = Size.Medium;
            t.Size = Size.Large;
            Assert.Equal<double>(1.49, t.Price);
            Assert.Equal<uint>(8, t.Calories);
            Assert.Equal<Size>(Size.Large, t.Size);
        }
        [Fact]
        public void CanAddIce()
        {
            JurassicJava t = new JurassicJava();
            t.AddIce();
            Assert.True(t.Ice);
        }
        [Fact]
        public void CanLeaveRoomForCream()
        {
            JurassicJava t = new JurassicJava();
            t.LeaveRoomForCream();
            Assert.True(t.RoomForCream);
        }
        [Fact]
        public void CorrectIngredients()
        {
            JurassicJava t = new JurassicJava();
            List<string> ingre = t.Ingredients;
            Assert.Contains<string>("Water", ingre);
            Assert.Contains<string>("Coffee", ingre);
            Assert.Equal<int>(2, ingre.Count);
        }

        [Fact]
        public void IndividualSpecialTests()
        {
            JurassicJava addIce = new JurassicJava();
            addIce.AddIce();
            Assert.Contains("Add Ice", addIce.Special);
            Assert.Single(addIce.Special);
            JurassicJava cream = new JurassicJava();
            cream.LeaveRoomForCream();
            Assert.Contains("Leave Room For Cream", cream.Special);
            Assert.Single(cream.Special);
        }
        [Fact]
        public void MultipleSpecialTest()
        {
            JurassicJava j = new JurassicJava();
            j.AddIce();
            j.LeaveRoomForCream();
            Assert.Contains("Add Ice", j.Special);
            Assert.Contains("Leave Room For Cream", j.Special);
            string[] arr = j.Special;
            Assert.Equal<int>(2, arr.Length);
        }
        [Theory]
        [InlineData("Special")]
        public void HoldingItemsShouldNotifyOfPropertyChange(string s)
        {
            JurassicJava dn = new JurassicJava();
            Assert.PropertyChanged(dn, s, () => { dn.AddIce(); });
        }
        [Theory]
        [InlineData("Decaf")]
        [InlineData("Description")]
        public void MakingDecafShouldNotifyOfPropertyChange(string s)
        {
            JurassicJava dn = new JurassicJava();
            Assert.PropertyChanged(dn, s, () => { dn.Decaf = true; });
        }

        [Theory]
        [InlineData("Description")]
        [InlineData("Size")]
        [InlineData("Price")]
        [InlineData("Calories")]
        public void ChangingSizeShouldNotifyOfPropertyChange(string s)
        {
            JurassicJava w = new JurassicJava();

            Assert.PropertyChanged(w, s, () => { w.Size = Size.Medium; });
            Assert.PropertyChanged(w, s, () => { w.Size = Size.Large; });
            Assert.PropertyChanged(w, s, () => { w.Size = Size.Small; });
        }
    }
}
