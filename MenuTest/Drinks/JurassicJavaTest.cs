using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using DinoDiner.Menu.Drinks;

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
    }
}
