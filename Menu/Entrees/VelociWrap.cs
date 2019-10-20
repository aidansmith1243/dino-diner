/* VelociWrap.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree class to hold all the information about the current entree.
    /// </summary>
    public class VelociWrap: Entree
    {
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool dressing = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool cheese = true;


        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Flour Tortilla","Chicken Breast" };
                if (dressing) ingredients.Add("Ceasar Dressing");
                if (lettuce) ingredients.Add("Romaine Lettuce");
                if (cheese) ingredients.Add("Parmesan Cheese");
                return ingredients;
            }
        }
        /// <summary>
        /// Gives special info about this item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!dressing) special.Add("Hold Dressing");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!cheese) special.Add("Hold Cheese");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public VelociWrap()
        {
            this.Price = 6.86;
            this.Calories = 356;
        }
        /// <summary>
        /// Removes "Ceasar Dressing" from the ingredients list
        /// </summary>
        public void HoldDressing()
        {
            this.dressing = false;
        }
        /// <summary>
        /// Removes "Romaine Lettuce" from the ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Removes "Parmesan Cheese" from the ingredients list
        /// </summary>
        public void HoldCheese()
        {
            this.cheese = false;
        }
        /// <summary>
        /// Gives a string description of this entree.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Veloci-Wrap";
        }
    }
}
