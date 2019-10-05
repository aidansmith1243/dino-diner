/* MeteorMacAndCheese.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Side dish class to provide all the information about this side.
    /// </summary>
    public class MeteorMacAndCheese: Side
    {
        private Size size;
        /// <summary>
        /// Will set the size and adjust the price and calories.
        /// <Returns>The current size</Returns>
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 420;
                        break;
                    case Size.Medium:
                        Price = 1.45;
                        Calories = 490;
                        break;
                    case Size.Large:
                        Price = 1.95;
                        Calories = 520;
                        break;
                }

            }
        }
        /// <summary>
        /// Develops the list of ingredients in the current side.
        /// <Returns>All of the ingredients in a string List</Returns>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Macaroni Noodles");
                ingredients.Add("Cheese Product");
                ingredients.Add("Pork Sausage");
                return ingredients;
            }
        }


        /// <summary>
        /// Constructor to set up the calories and price for this side.
        /// </summary>
        public MeteorMacAndCheese()
        {
            Calories = 420;
            Price = 0.99;

        }
    }
}
