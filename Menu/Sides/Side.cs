/* Side.cs
 * Author: Nathan Bean
 * Modified by: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Abstract side class to hold properties for price, ingredients, calories, and ingredients.
    /// </summary>
    public abstract class Side: IMenuItem, IOrderItem
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
        /// <summary>
        /// Gives a description of this item
        /// </summary>
        public virtual string Description
        {
            get 
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Lists anything special about this item.
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                string[] arr = { };
                return arr;
            }
        }
    }
}
