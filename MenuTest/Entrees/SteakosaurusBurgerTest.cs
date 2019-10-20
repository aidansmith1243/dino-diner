using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class SteakosaurusBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal(5.15, sb.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            Assert.Equal<uint>(621, sb.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            List<string> ingredients = sb.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            Assert.Contains<string>("Steakburger Pattie", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", sb.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", sb.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", sb.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            SteakosaurusBurger sb = new SteakosaurusBurger();
            sb.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", sb.Ingredients);
        }
        [Fact]
        public void IndividualSpecialTest()
        {
            SteakosaurusBurger bun = new SteakosaurusBurger();
            bun.HoldBun();
            Assert.Contains("Hold Bun", bun.Special);
            Assert.Single(bun.Special);

            SteakosaurusBurger pickle = new SteakosaurusBurger();
            pickle.HoldPickle();
            Assert.Contains("Hold Pickle", pickle.Special);
            Assert.Single(pickle.Special);

            SteakosaurusBurger ketchup = new SteakosaurusBurger();
            ketchup.HoldKetchup();
            Assert.Contains("Hold Ketchup", ketchup.Special);
            Assert.Single(ketchup.Special);

            SteakosaurusBurger mustard = new SteakosaurusBurger();
            mustard.HoldMustard();
            Assert.Contains("Hold Mustard", mustard.Special);
            Assert.Single(mustard.Special);

        }

        [Fact]
        public void MultipleSpecialTest()
        {
            SteakosaurusBurger v = new SteakosaurusBurger();
            v.HoldBun();
            v.HoldKetchup();
            v.HoldMustard();
            v.HoldPickle();
            Assert.Contains("Hold Bun", v.Special);
            Assert.Contains("Hold Ketchup", v.Special);
            Assert.Contains("Hold Pickle", v.Special);
            Assert.Contains("Hold Mustard", v.Special);
            string[] arr = v.Special;
            Assert.Equal<int>(4, arr.Length);
        }
    }

}
