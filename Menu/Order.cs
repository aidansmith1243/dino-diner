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
        /// Backing variable for Items
        ObservableCollection<IOrderItem> items = new ObservableCollection<IOrderItem>();
        /// <summary>
        /// holds the list of items in the order and returns an array of the items.
        /// </summary>
        public ObservableCollection<IOrderItem> Items { 
            get {
                return items; 
            } 
        }
        /// <summary>
        /// Adds the item to the order and notifies of properties changed
        /// </summary>
        /// <param name="i"></param>
        public void Add(IOrderItem i)
        {
            i.PropertyChanged += OnItemPropertyChanged;
            items.Add(i);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        /// <summary>
        /// Remove an item from the list and returns if it could be removed.
        /// </summary>
        /// <param name="i"></param>
        /// <returns></returns>
        public bool Remove(IOrderItem i)
        {
            bool removed = items.Remove(i);
            if (removed)
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
            }
            return removed;
        }
        /// <summary>
        /// Notifies when an item has been changed in the list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SubtotalCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SalesTaxCost"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalCost"));
        }
        // end new code

        public Order()
        {
           
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
        /// Event for when a property is changed
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
