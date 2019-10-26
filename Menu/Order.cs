/* Order.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using System.Collections.ObjectModel;
using System.Collections.Specialized;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Class to hold a customers order.
    /// </summary>
    public class Order: INotifyPropertyChanged
    {

        public Order()
        {
            Items.CollectionChanged += OnCollectionChanged;
        }

        /// <summary>
        /// List to hold all of the items in the order.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { get; set; } = new ObservableCollection<IOrderItem>();
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
        /// Gives the sales tax rate. You never said what you wanted for default sales tax
        /// </summary>
        public double SalesTaxRate { get; protected set; } = 0.15;
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
        /// <summary>
        /// Notifies that the property "SubtotalCost" has been changed
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        public void OnCollectionChanged(object sender, NotifyCollectionChangedEventArgs args)
        {
            NotifyOfPropertyChanged("SubtotalCost");
            NotifyOfPropertyChanged("TotalCost");
            NotifyOfPropertyChanged("SalesTaxCost");
        }

        /// <summary>
        /// event for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper method for event when a property is changed
        /// </summary>
        /// <param name="propertyName"></param>
        private void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
