using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class VelociWrapUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal(6.86, vw.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            VelociWrap vw = new VelociWrap();
            Assert.Equal<uint>(356, vw.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            VelociWrap vw = new VelociWrap();
            List<string> ingredients = vw.Ingredients;
            Assert.Contains<string>("Flour Tortilla", ingredients);
            Assert.Contains<string>("Chicken Breast", ingredients);
            Assert.Contains<string>("Romaine Lettuce", ingredients);
            Assert.Contains<string>("Ceasar Dressing", ingredients);
            Assert.Contains<string>("Parmesan Cheese", ingredients);
            Assert.Equal<int>(5, ingredients.Count);
        }

        [Fact]
        public void HoldDressingShouldRemoveDressing()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldDressing();
            Assert.DoesNotContain<string>("Dressing", vw.Ingredients);
        }

        [Fact]
        public void HoldLettuceShouldRemoveLettuce()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldLettuce();
            Assert.DoesNotContain<string>("Lettuce", vw.Ingredients);
        }

        [Fact]
        public void HoldCheeseShouldRemoveCheese()
        {
            VelociWrap vw = new VelociWrap();
            vw.HoldCheese();
            Assert.DoesNotContain<string>("Parmesan Cheese", vw.Ingredients);
        }
        [Fact]
        public void IndividualSpecialTest()
        {
            VelociWrap dressing = new VelociWrap();
            dressing.HoldDressing();
            Assert.Contains("Hold Dressing", dressing.Special);
            Assert.Single(dressing.Special);

            VelociWrap lettuce = new VelociWrap();
            lettuce.HoldLettuce();
            Assert.Contains("Hold Lettuce", lettuce.Special);
            Assert.Single(lettuce.Special);

            VelociWrap cheese = new VelociWrap();
            cheese.HoldCheese();
            Assert.Contains("Hold Cheese", cheese.Special);
            Assert.Single(cheese.Special);

        }

        [Fact]
        public void MultipleSpecialTest()
        {
            VelociWrap v = new VelociWrap();
            v.HoldDressing();
            v.HoldLettuce();
            v.HoldCheese();
            Assert.Contains("Hold Dressing", v.Special);
            Assert.Contains("Hold Lettuce", v.Special);
            Assert.Contains("Hold Cheese", v.Special);
            string[] arr = v.Special;
            Assert.Equal<int>(3, arr.Length);
        }
        [Theory]
        [InlineData("Special")]
        [InlineData("Ingredients")]
        public void HoldingItemsShouldNotifyOfPropertyChange(string s)
        {
            VelociWrap dn = new VelociWrap();
            Assert.PropertyChanged(dn, s, () => { dn.HoldCheese(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldDressing(); });
            Assert.PropertyChanged(dn, s, () => { dn.HoldLettuce(); });

        }
    }
}
