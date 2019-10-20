/* Order.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to hold a customers order.
    /// </summary>
    public class Order
    {
        /// <summary>
        /// List to hold all of the items in the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; }
        /// <summary>
        /// Calculates the total price from the price of all the items.
        /// </summary>
        public double SubtotalCost
        {
            get
            {
                double cost = 0;
                foreach(IOrderItem i in Items)
                {
                    cost += i.Price;
                }
                return cost;
            }
        }
        /// <summary>
        /// Gives the sales tax rate.
        /// </summary>
        public double SalesTaxRate { get; protected set; }
        /// <summary>
        /// Calculates the cost from the sales tax
        /// </summary>
        public double SalesTaxCost 
        {
            get
            {
                return SalesTaxRate * SubtotalCost;
            }
        }
        /// <summary>
        /// Gives the total cost of the order
        /// </summary>
        public double TotalCost 
        {
            get
            {
                return SubtotalCost + SalesTaxCost;
            }
        }
    }
}
