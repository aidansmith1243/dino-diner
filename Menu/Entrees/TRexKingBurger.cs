/* TRexKingBurger.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// Entree class to hold all the information about the current entree.
    /// </summary>
    public class TRexKingBurger: Entree
    {
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool bun = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool lettuce = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool tomato = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool onion = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool pickle = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool ketchup = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool mustard = true;
        /// <summary>
        /// Backing Variable
        /// </summary>
        private bool mayo = true;

        /// <summary>
        /// Adds all of the ingredients to the list.
        /// <return>A list of strings with all of the ingredients included</return>
        /// </summary>
        public override List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {};
                for(int i = 0; i < 3; i++)
                {
                    ingredients.Add("Steakburger Pattie");
                }
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (lettuce) ingredients.Add("Lettuce");
                if (tomato) ingredients.Add("Tomato");
                if (onion) ingredients.Add("Onion");
                if (pickle) ingredients.Add("Pickle");
                if (ketchup) ingredients.Add("Ketchup");
                if (mustard) ingredients.Add("Mustard");
                if (mayo) ingredients.Add("Mayo");
                return ingredients;
            }
        }
        /// <summary>
        /// Gives special info about this item
        /// </summary>
        public override string[] Special
        {
            get
            {
                List<string> special = new List<string>();
                if (!bun) special.Add("Hold Bun");
                if (!lettuce) special.Add("Hold Lettuce");
                if (!tomato) special.Add("Hold Tomato");
                if (!onion) special.Add("Hold Onion");
                if (!pickle) special.Add("Hold Pickle");
                if (!ketchup) special.Add("Hold Ketchup");
                if (!mustard) special.Add("Hold Mustard");
                if (!mayo) special.Add("Hold Mayo");
                return special.ToArray();
            }
        }
        /// <summary>
        /// Constructor to initiate the price and calories.
        /// </summary>
        public TRexKingBurger()
        {
            this.Price = 8.45;
            this.Calories = 728;
        }
        /// <summary>
        /// Removes "Whole Wheat Bun" from the ingredients list
        /// </summary>
        public void HoldBun()
        {
            this.bun = false;
        }
        /// <summary>
        /// Removes "Lettuce" from the ingredients list
        /// </summary>
        public void HoldLettuce()
        {
            this.lettuce = false;
        }
        /// <summary>
        /// Removes "Tomato" from the ingredients list
        /// </summary>
        public void HoldTomato()
        {
            this.tomato = false;
        }
        /// <summary>
        /// Removes "Onion" from the ingredients list
        /// </summary>
        public void HoldOnion()
        {
            this.onion = false;
        }
        /// <summary>
        /// Removes "Pickle" from the ingredients list
        /// </summary>
        public void HoldPickle()
        {
            this.pickle = false;
        }
        /// <summary>
        /// Removes "Ketchup" from the ingredients list
        /// </summary>
        public void HoldKetchup()
        {
            this.ketchup = false;
        }
        /// <summary>
        /// Removes "Mustard" from the ingredients list
        /// </summary>
        public void HoldMustard()
        {
            this.mustard = false;
        }
        /// <summary>
        /// Removes "Mayo" from the ingredients list
        /// </summary>
        public void HoldMayo()
        {
            this.mayo = false;
        }
        /// <summary>
        /// Gives a string description of this entree.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            return "T-Rex King Burger";
        }
    }
}
