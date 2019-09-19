﻿/* Pterodactyl.cs
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
    public class PterodactylWings: Entree
    {

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Chicken","Wing Sauce" };
                
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public PterodactylWings()
        {
            this.Price = 7.21;
            this.Calories = 318;
        }


    }
}

