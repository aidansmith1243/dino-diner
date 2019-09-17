﻿/* DinNuggets.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class DinoNuggets
    {
        private uint nuggets = 6;
        public double Price { get; set; }
        public uint Calories { get; set; }

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggets;
        }
        /// <summary>
        /// Adds one nugget to the order and increases the price and calories for
        /// the new nugget.
        /// </summary>
        public void AddNugget()
        {
            this.nuggets++;
            this.Price += 0.25;
            this.Calories += 59;
        }
    }
}