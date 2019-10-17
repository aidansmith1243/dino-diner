/* DinNuggets.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree class to hold all the information about the current entree.
    /// </summary>
    public class DinoNuggets: Entree, INotifyPropertyChanged
    {
        /// <summary>
        /// Store the number of nuggets in this order
        /// </summary>
        private uint nuggets = 6;

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyOfPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for (int i = 0; i < nuggets; i++)
                {
                    ingredients.Add("Chicken Nugget");
                }
                return ingredients;
            }
        }

        public string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (nuggets > 6)
                    special.Add($"{nuggets - 6} Extra Nuggets");
                return special.ToArray();
            }
        }

        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public DinoNuggets()
        {
            this.Price = 4.25;
            this.Calories = 59 * nuggets;
        }
        /// <summary>
        /// Adds one nugget to the order and increases the price and calories for
        /// the new nugget.
        /// </summary>
        public void AddNugget()
        {
            this.nuggets++;
            this.Price += 0.25;
            this.Calories += 59;
            NotifyOfPropertyChanged("Price");
            NotifyOfPropertyChanged("Calories");
            NotifyOfPropertyChanged("Special");
            NotifyOfPropertyChanged("Ingredients");
        }
        /// <summary>
        /// Gives a string description of this entree.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "Dino-Nuggets";
        }
    }
}
