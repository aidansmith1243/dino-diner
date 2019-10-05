using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// A type of drink that has special ingredients, prices, calories, and methods.
    /// </summary>
    public class Sodasaurus: Drink
    {
        private Size size;
        private SodasaurusFlavor flavor;
        /// <summary>
        /// Property to change the flavor of the soda.
        /// </summary>
        public SodasaurusFlavor Flavor
        {
            get
            {
                return this.flavor;
            }
            set
            {
                this.flavor = value;
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
                        Price = 1.50;
                        Calories = 112;
                        break;
                    case Size.Medium:
                        Price = 2.00;
                        Calories = 156;
                        break;
                    case Size.Large:
                        Price = 2.50;
                        Calories = 208;
                        break;
                }
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
                ingredients.Add("Natural Flavors");
                ingredients.Add("Cane Sugar");
                return ingredients;
            }
        }
        /// <summary>
        /// Create the soda with a size of small and defaults to cola.
        /// </summary>
        public Sodasaurus()
        {
            Size = Size.Small;
            Flavor = SodasaurusFlavor.Cola;

        }
        /// <summary>
        /// Gives a string description of this drink.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            
            return Size + " " + Flavor + " Sodasaurus";
        }
    }
}
