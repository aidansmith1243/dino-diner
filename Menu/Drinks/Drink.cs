/*
 * Drink.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This enum is used to get the variety of drink sizes
    /// </summary>
    public enum Size
    {
        /// <summary>
        /// The smallest size drink that we offer
        /// </summary>
        Small,
        /// <summary>
        /// The size if you think large is too much and small is not enough.
        /// </summary>
        Medium,
        /// <summary>
        /// Order large if you are very thirsty.
        /// </summary>
        Large
    }
    /// <summary>
    /// Base class for all of the drink classes to hold the basics of all of the drinks.
    /// </summary>
    public abstract class Drink: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Holds the list of ingredients that are contained in the drink.
        /// </summary>
        public abstract List<string> Ingredients { get; }
        /// <summary>
        /// The price of the drink.
        /// </summary>
        public double Price { get; set; }
        /// <summary>
        /// The amount of calories that are in the drink.
        /// </summary>
        public uint Calories { get; set; }
        /// <summary>
        /// Whether or not the drink contains ice, defaults to true;
        /// </summary>
        public bool Ice { get; set; } = true;
        /// <summary>
        /// The size of the drink using the size enum.
        /// </summary>
        public abstract Size Size { get; set; }
        /// <summary>
        /// Method to remove ice from the drink.
        /// </summary>
        public virtual void HoldIce()
        {
            Ice = false;
            NotifyOfPropertyChanged("Ice");
            NotifyOfPropertyChanged("Special");
        }
        /// <summary>
        /// Gives a description of the drink
        /// </summary>
        public virtual string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Gives anything special needed for the drink
        /// </summary>
        public virtual string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!Ice) special.Add("Hold Ice");
                return special.ToArray();
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
