/*
 * IOrderItem.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Interface for any item that will be ordered.
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the object to be ordered.
        /// </summary>
        double Price { get; }
        /// <summary>
        /// A description of the ordered objects.
        /// </summary>
        string Description { get; }
        /// <summary>
        /// Anything that is special about this ordered item.
        /// </summary>
        string[] Special { get; }
    }
}
