/* Entree.cs
 * Author: Aidan Smith 
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    /// <summary>
    /// abstract class to store the ingredients, price, and calories for an entree.
    /// </summary>
    public abstract class Entree
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
    }
}
