/* Entree.cs
 * Author: Aidan Smith 
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// abstract class to store the ingredients, price, and calories for an entree.
    /// </summary>
    public abstract class Entree: IMenuItem, IOrderItem, INotifyPropertyChanged
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
        public virtual string Description { get { return this.ToString(); } }

        /// <summary>
        /// Gives the special methods for each seperate class
        /// </summary>
        public virtual string[] Special 
        {
            get 
            {
                string[] arr = { };
                return arr; 
            } 
        }
        /// <summary>
        /// event for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;
        /// <summary>
        /// Helper method for event when a property is changed
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
