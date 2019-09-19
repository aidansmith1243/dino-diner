/* SteakosaurusBurger.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// Entree class to hold all the information about the current entree.
    /// </summary>
    public class SteakosaurusBurger: Entree
    {
        private bool bun = true;
        private bool pickle = true;
        private bool ketchup = true;
        private bool mustard = true;

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Steakburger Pattie" };
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public SteakosaurusBurger()
        {
            this.Price = 5.15;
            this.Calories = 621;
        }
        /// <summary>
        /// Removes "Whole Wheat Bun" from the ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Removes "Pickle" from the ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Removes "Ketchup" from the ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Removes "Mustard" from the ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
    }
}
