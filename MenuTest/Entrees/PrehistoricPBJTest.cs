using System.Collections.Generic;
using Xunit;
using DinoDiner.Menu;

namespace MenuTest.Entrees
{
    public class PrehistoricPBJUnitTest
    {
        [Fact]
        public void ShouldHaveCorrectDefaultPrice()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal(6.52, pbj.Price, 2);
        }

        [Fact]
        public void ShouldHaveCorrectDefaultCalories()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal<uint>(483, pbj.Calories);
        }

        [Fact]
        public void ShouldListDefaultIngredients()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            List<string> ingredients = pbj.Ingredients;
            Assert.Contains<string>("Bread", ingredients);
            Assert.Contains<string>("Peanut Butter", ingredients);
            Assert.Contains<string>("Jelly", ingredients);
            Assert.Equal<int>(3, ingredients.Count);
        }

        [Fact]
        public void HoldPeanutButterShouldRemovePeanutButter()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldPeanutButter();
            Assert.DoesNotContain<string>("Peanut Butter", pbj.Ingredients);
        }

        [Fact]
        public void HoldJellyShouldRemoveJelly()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            pbj.HoldJelly();
            Assert.DoesNotContain<string>("Jelly", pbj.Ingredients);
        }

        [Fact]
        public void ShouldProvideCorrectDescription()
        {
            PrehistoricPBJ pbj = new PrehistoricPBJ();
            Assert.Equal("Prehistoric PB&J", pbj.Description);
        }

        [Fact]
        public void IndividualSpecialTest()
        {
            PrehistoricPBJ pb = new PrehistoricPBJ();
            pb.HoldPeanutButter();
            Assert.Contains("Hold Peanut Butter", pb.Special);
            Assert.Single(pb.Special);

            PrehistoricPBJ jelly = new PrehistoricPBJ();
            jelly.HoldJelly();
            Assert.Contains("Hold Jelly", jelly.Special);
            Assert.Single(jelly.Special);

        }

        [Fact]
        public void MultipleSpecialTest()
        {
            PrehistoricPBJ v = new PrehistoricPBJ();
            v.HoldPeanutButter();
            v.HoldJelly();
            Assert.Contains("Hold Peanut Butter", v.Special);
            Assert.Contains("Hold Jelly", v.Special);
            string[] arr = v.Special;
            Assert.Equal<int>(2, arr.Length);
        }
    }

}
