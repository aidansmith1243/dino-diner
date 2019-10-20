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

        public Order()
        {
            items = new ObservableCollection<IOrderItem>();
            salesTaxRate = 0.15;
        }
        private ObservableCollection<IOrderItem> items;
        /// <summary>
        /// List to hold all of the items in the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items 
        {
            get 
            {
                return items;
            } 
            set 
            {
                items = value;
            }
        }
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
                if (cost < 0)
                    return 0;
                return cost;
            }
        }
        /// <summary>
        /// Backing variable
        /// </summary>
        private double salesTaxRate;
        /// <summary>
        /// Gives the sales tax rate. You never said what you wanted for default sales tax
        /// </summary>
        public double SalesTaxRate { get { return salesTaxRate; } protected set { salesTaxRate = value; } }
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
