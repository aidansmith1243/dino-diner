using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class TRexKingBurgerUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal(8.45, trex.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            TRexKingBurger trex = new TRexKingBurger();
            Assert.Equal<uint>(728, trex.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            TRexKingBurger trex = new TRexKingBurger();
            List<string> ingredients = trex.Ingredients;
            Assert.Contains<string>("Whole Wheat Bun", ingredients);
            // Should be three patties
            int count = 0;
            foreach(string ingredient in ingredients)
            {
                if (ingredient.Equals("Steakburger Pattie")) count++;
            }
            Assert.Equal<int>(3, count);
            Assert.Contains<string>("Lettuce", ingredients);
            Assert.Contains<string>("Tomato", ingredients);
            Assert.Contains<string>("Onion", ingredients);
            Assert.Contains<string>("Pickle", ingredients);
            Assert.Contains<string>("Ketchup", ingredients);
            Assert.Contains<string>("Mustard", ingredients);
            Assert.Contains<string>("Mayo", ingredients);
            Assert.Equal<int>(11, ingredients.Count);
        }

        [Fact]
        public void HoldBunShouldRemoveBun()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldBun();
            Assert.DoesNotContain<string>("Whole Wheat Bun", trex.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", trex.Ingredients);
        }

        [Fact]
        public void HoldTomatoShouldRemoveTomato()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldTomato();
            Assert.DoesNotContain<string>("Tomato", trex.Ingredients);
        }

        [Fact]
        public void HoldOnionShouldRemoveOnion()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldOnion();
            Assert.DoesNotContain<string>("Onion", trex.Ingredients);
        }

        [Fact]
        public void HoldPickleShouldRemovePickle()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldPickle();
            Assert.DoesNotContain<string>("Pickle", trex.Ingredients);
        }

        [Fact]
        public void HoldKetchupShouldRemoveKetchup()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldKetchup();
            Assert.DoesNotContain<string>("Ketchup", trex.Ingredients);
        }

        [Fact]
        public void HoldMustardShouldRemoveMustard()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMustard();
            Assert.DoesNotContain<string>("Mustard", trex.Ingredients);
        }

        [Fact]
        public void HoldMayoShouldRemoveMayo()
        {
            TRexKingBurger trex = new TRexKingBurger();
            trex.HoldMayo();
            Assert.DoesNotContain<string>("Mayo", trex.Ingredients);
        }
        [Fact]
        public void IndividualSpecialTest()
        {
            TRexKingBurger bun = new TRexKingBurger();
            bun.HoldBun();
            Assert.Contains("Hold Bun", bun.Special);
            Assert.Single(bun.Special);

            TRexKingBurger lettuce = new TRexKingBurger();
            lettuce.HoldLettuce();
            Assert.Contains("Hold Lettuce", lettuce.Special);
            Assert.Single(lettuce.Special);

            TRexKingBurger tomato = new TRexKingBurger();
            tomato.HoldTomato();
            Assert.Contains("Hold Tomato", tomato.Special);
            Assert.Single(tomato.Special);

            TRexKingBurger onion = new TRexKingBurger();
            onion.HoldOnion();
            Assert.Contains("Hold Onion", onion.Special);
            Assert.Single(onion.Special);

            TRexKingBurger pickle = new TRexKingBurger();
            pickle.HoldPickle();
            Assert.Contains("Hold Pickle", pickle.Special);
            Assert.Single(pickle.Special);

            TRexKingBurger ketchup = new TRexKingBurger();
            ketchup.HoldKetchup();
            Assert.Contains("Hold Ketchup", ketchup.Special);
            Assert.Single(ketchup.Special);

            TRexKingBurger mustard = new TRexKingBurger();
            mustard.HoldMustard();
            Assert.Contains("Hold Mustard", mustard.Special);
            Assert.Single(mustard.Special);

            TRexKingBurger mayo = new TRexKingBurger();
            mayo.HoldMayo();
            Assert.Contains("Hold Mayo", mayo.Special);
            Assert.Single(mayo.Special);

        }

        [Fact]
        public void MultipleSpecialTest()
        {
            TRexKingBurger x = new TRexKingBurger();
            x.HoldMustard();
            x.HoldBun();
            x.HoldKetchup();
            x.HoldLettuce();
            x.HoldMayo();
            x.HoldOnion();
            x.HoldPickle();
            x.HoldTomato();
            Assert.Contains("Hold Mayo", x.Special);
            Assert.Contains("Hold Mustard", x.Special);
            Assert.Contains("Hold Ketchup", x.Special);
            Assert.Contains("Hold Pickle", x.Special);
            Assert.Contains("Hold Onion", x.Special);
            Assert.Contains("Hold Tomato", x.Special);
            Assert.Contains("Hold Lettuce", x.Special);
            Assert.Contains("Hold Bun", x.Special);
            string[] arr = x.Special;
            Assert.Equal<int>(8, arr.Length);
        }
        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void HoldingItemsShouldNotifyOfPropertyChange(string s)
        {
            TRexKingBurger dn = new TRexKingBurger();
            Assert.PropertyChanged(dn, s, () => { dn.HoldBun(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldKetchup(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldLettuce(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldMayo(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldMustard(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldOnion(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldPickle(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldTomato(); });

        }
    }

}
