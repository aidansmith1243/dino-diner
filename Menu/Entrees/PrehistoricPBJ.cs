/* PrehistoricPBJ.cs
 * Author: Nathan Bean
 * Modified by: Aidan Smith
 */
using System.Collections.Generic;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree class to hold all the information about the current entree.
    /// </summary>
    public class PrehistoricPBJ:Entree
    {
        private bool peanutButter = true;
        private bool jelly = true;

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() { "Bread" };
                if (peanutButter) ingredients.Add("Peanut Butter");
                if (jelly) ingredients.Add("Jelly");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public PrehistoricPBJ()
        {
            this.Price = 6.52;
            this.Calories = 483;
        }
        /// <summary>
        /// Removes "Peanut Butter" from the ingredients list
        /// </summary>
        public void HoldPeanutButter()
        {
            this.peanutButter = false;
        }
        /// <summary>
        /// Removes "Jelly" from the ingredients list
        /// </summary>
        public void HoldJelly()
        {
            this.jelly = false;
        }
        /// <summary>
        /// Gives a string description of this entree.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Prehistoric PB&J";
        }
    }
}
