/* Entree.cs
 * Author: Aidan Smith 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// abstract class to store the ingredients, price, and calories for an entree.
    /// </summary>
    public abstract class Entree: IMenuItem//, IOrderItem
    {
        /// <summary>
        /// Gets the ingredients list
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// Gets and sets the price
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// Gets and sets the calories
        /// </summary>
        public uint Calories { get; set; }

        /// <summary>
        /// Gets the description
        /// </summary>
        public string Description { get { return this.ToString(); } }

        /// <summary>
        /// Gives the special methods for each seperate class
        /// </summary>
        //public virtual string[] Special { get { return new List<string>().ToArray(); } }

    }
}
