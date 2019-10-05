﻿/* Brontowurst.cs
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
    public class Brontowurst: Entree
    {
        private bool peppers = true;
        private bool onion = true;
        private bool bun = true;

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onion) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }
        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        /// <summary>
        /// This method will remove "Whole Wheat Bun" from the ingredients list.
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// This method removes "Peppers" from the ingredients list.
        /// </summary>
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        /// <summary>
        /// This method removes "Onion" from the ingredient list.
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// Gives a string description of this entree.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Brontowurst";
        }

    }
}
