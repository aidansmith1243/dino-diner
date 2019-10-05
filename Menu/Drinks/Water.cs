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
            }
        }
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
        }
    }
}
