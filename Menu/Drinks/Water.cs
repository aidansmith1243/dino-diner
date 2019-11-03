/* Water.cs
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
    public class Water: Drink
    {
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
        /// Backing Variable
        /// </summary>
        private Size size;
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
                Price = 0.10;
                Calories = 0;
                NotifyOfPropertyChanged("Size");
                NotifyOfPropertyChanged("Description");
                NotifyOfPropertyChanged("Price");
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
                if(Lemon) ingredients.Add("Lemon");
                return ingredients;
            }
        }
        /// <summary>
        /// Creates a basic cup of water that is size small and no lemon.
        /// </summary>
        public Water()
        {
            Size = Size.Small;
            Lemon = false;

        }
        /// <summary>
        /// Adds a lemon for a nice refreshing drink.
        /// </summary>
        public void AddLemon()
        {
            Lemon = true;
            // Notify is in the property value
        }
        /// <summary>
        /// Gives a string description of this drink.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return Size + " Water";
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
