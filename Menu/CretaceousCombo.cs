﻿/*
 * CretaceousCombo.cs
 * Author: Nathan Bean
 * Modified by: Aidan Smith
 */
using System.Collections.Generic;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A class representing a combo meal
    /// </summary>
    public class CretaceousCombo: IMenuItem, IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// Backing variable for Size
        /// </summary>
        private Size size;

        /// <summary>
        /// Gets and sets the entree
        /// </summary>
        public Entree Entree { get; set; }
        /// <summary>
        /// Backing variable for side
        /// </summary>
        private Side side = new Fryceritops();
        /// <summary>
        /// Gets and sets the side
        /// </summary>
        public Side Side 
        { 
            get
            {
                return side;
            }
            set
            {
                side = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                side.PropertyChanged += OnItemPropertyChanged;
            }
        }

        /// <summary>
        /// Backing variable
        /// </summary>
        private Drink drink = new Sodasaurus();
        /// <summary>
        /// Gets and sets the drink
        /// </summary>
        public Drink Drink 
        { 
            get 
            { 
                return drink;
            } 
            set 
            { 
                drink = value;
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
                NotifyOfPropertyChanged("Price");
                drink.PropertyChanged += OnItemPropertyChanged;
            } 
        }

        /// <summary>
        /// Gets the price of the combo
        /// </summary>
        public double Price
        {
            get
            {
                return Entree.Price + Side.Price + Drink.Price - 0.25;
            }
        }

        /// <summary>
        /// Gets the calories of the combo
        /// </summary>
        public uint Calories
        {
            get
            {
                return Entree.Calories + Side.Calories + Drink.Calories;
            }
        }

        /// <summary>
        /// Gets or sets the size of the combo
        /// </summary>
        public Size Size
        {
            get { return size; }
            set
            {
                size = value;
                Drink.Size = value;
                Side.Size = value;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }

        /// <summary>
        /// Gets the list of ingredients for the combo
        /// </summary>
        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.AddRange(Entree.Ingredients);
                ingredients.AddRange(Side.Ingredients);
                ingredients.AddRange(Drink.Ingredients);
                return ingredients;
            }
        }
        /// <summary>
        /// Gives all the special requirements for this item
        /// </summary>
        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                special.AddRange(Entree.Special);
                special.Add(Side.Description);
                special.AddRange(Side.Special);
                special.Add(Drink.Description);
                special.AddRange(Drink.Special);

                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructs a new combo with the specified entree
        /// </summary>
        /// <param name="entree">The entree to use</param>
        public CretaceousCombo(Entree entree)
        {
            this.Entree = entree;
            Entree.PropertyChanged += OnItemPropertyChanged;
            Drink.PropertyChanged += OnItemPropertyChanged;
            Side.PropertyChanged += OnItemPropertyChanged;
        }
        /// <summary>
        /// Gives a string description of this combo.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Entree.ToString() + " Combo";
        }
        /// <summary>
        /// Gives a description of this item
        /// </summary>
        public string Description
        {
            get
            {
                return this.ToString();
            }
        }
        /// <summary>
        /// Notify of all the changes to the object
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="args"></param>
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs args)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Special"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Description"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
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
