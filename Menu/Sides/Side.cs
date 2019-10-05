/* Side.cs
 * Author: Nathan Bean
 * Modified by: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /*
    /// <summary>
    /// Enum to hold different size sides.
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// The smallest size of a side you can order.
        /// </summary>
        Small,
        /// <summary>
        /// The side that you want when small is not enough and large is too much.
        /// </summary>
        Medium, 
        /// <summary>
        /// Size for if you want a lot of food.
        /// </summary>
        Large
    }*/
    /// <summary>
    /// Abstract side class to hold properties for price, ingredients, calories, and ingredients.
    /// </summary>
    public abstract class Side
    {
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }

        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }

        /// <summary>
        /// Gets or sets the size
        /// </summary>
        public abstract Size Size { get; set; }

    }
}
