using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class BrontowurstUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal(5.36, bw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            Brontowurst bw = new Brontowurst();
            Assert.Equal<uint>(498, bw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            Brontowurst bw = new Brontowurst();
            List<string> ingredients = bw.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Brautwurst", ingredients);
            Assert.Contains<string>("Peppers", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Equal<int>(4, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", bw.Ingredients);
        }

        [Fact]
        public void HoldPeppersShouldRemovePeppers()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldPeppers();
            Assert.DoesNotContain<string>("Peppers", bw.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            Brontowurst bw = new Brontowurst();
            bw.HoldOnion();
            Assert.DoesNotContain<string>("Onion", bw.Ingredients);
        }
        [Fact]
        public void IndividualSpecialTest()
        {
            Brontowurst pepper = new Brontowurst();
            pepper.HoldPeppers();
            Assert.Contains("Hold Peppers", pepper.Special);
            Assert.Single(pepper.Special);

            Brontowurst onion = new Brontowurst();
            onion.HoldOnion();
            Assert.Contains("Hold Onion", onion.Special);
            Assert.Single(onion.Special);

            Brontowurst bun = new Brontowurst();
            bun.HoldBun();
            Assert.Contains("Hold Bun", bun.Special);
            Assert.Single(bun.Special);
        }

        [Fact]
        public void MultipleSpecialTest()
        {
            Brontowurst v = new Brontowurst();
            v.HoldBun();
            v.HoldOnion();
            v.HoldPeppers();
            Assert.Contains("Hold Onion", v.Special);
            Assert.Contains("Hold Peppers", v.Special);
            Assert.Contains("Hold Bun", v.Special);
            string[] arr = v.Special;
            Assert.Equal<int>(3, arr.Length);
        }
    }


}
