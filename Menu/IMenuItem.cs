/*
 * IMenuItem.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for to hold the basic properties of all menu items.
    /// </summary>
    public interface IMenuItem
    {
        /// <summary>
        /// Stores the price of the menu item
        /// </summary>
        double Price { get; }
        /// <summary>
        /// Stores the Calories of the menu item
        /// </summary>
        uint Calories { get; }
        /// <summary>
        /// Stores all of the ingredients in the menu item
        /// </summary>
        List<string> Ingredients { get; }
    }
}
