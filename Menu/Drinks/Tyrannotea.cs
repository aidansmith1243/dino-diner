﻿/* Tyrannotea.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A type of drink that has special ingredients, prices, calories, and methods.
    /// </summary>
    public class Tyrannotea: Drink
    {
        /// <summary>
        /// Backing variable
        /// </summary>
        private Size size;
        /// <summary>
        /// backing variable
        /// </summary>
        private bool sweet;
        /// <summary>
        /// Property to set if the customer wants sweet tea.
        /// </summary>
        public bool Sweet
        {
            get
            {
                return this.sweet;
            }
            set
            {
                this.sweet = value;
                Size = this.Size; // used to update Calorie count
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Special");
            }
        }
        /// <summary>
        /// Backing variable
        /// </summary>
        private bool lemon;
        /// <summary>
        /// Property to add a lemon to the drink.
        /// </summary>
        public bool Lemon
        {
            get
            {
                return this.lemon;
            }
            set
            {
                this.lemon = value;
                NotifyOfPropertyChanged("Ingredients");
                NotifyOfPropertyChanged("Special");
            }
        }
        /// <summary>
        /// Property to get and set the size of the drink and change the price and calories accordingly
        /// </summary>
        public override Size Size
        {
            get
            {
                return size;
            }
            set
            {
                this.size = value;
                switch (size)
                {
                    case Size.Small:
                        Price = 0.99;
                        Calories = 8;
                        break;
                    case Size.Medium:
                        Price = 1.49;
                        Calories = 16;
                        break;
                    case Size.Large:
                        Price = 1.99;
                        Calories = 32;
                        break;
                }
                if (Sweet) Calories *= 2;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
                NotifyOfPropertyChanged("Calories");
            }
        }
        /// <summary>
        /// Property that gives the ingredients of the current drink.
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>();
                ingredients.Add("Water");
                ingredients.Add("Tea");
                if(Sweet) ingredients.Add("Cane Sugar");
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Creates the tea with default size of small, not sweet, and no lemon.
        /// </summary>
        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;

        }
        /// <summary>
        /// Adds a lemon into the drink.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            // Notify is in property
        }
        /// <summary>
        /// Gives a string description of this drink.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            string str = "Tyrannotea";
            if (Sweet) str = "Sweet " + str;
            return Size + " " + str;
        }
        /// <summary>
        /// Anything Special for this drink.
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if(!Ice)special.Add("Hold Ice");
                if(Lemon) special.Add("Add Lemon");
                return special.ToArray();
            }
        }
    }
}
