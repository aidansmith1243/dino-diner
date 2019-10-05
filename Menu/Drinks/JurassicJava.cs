/*
 * JurassicJava.cs
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
    public class JurassicJava: Drink
    {
        private bool roomForCream;
        /// <summary>
        /// Property to say if the person wants to add cream on the java
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return this.roomForCream;
            }
            set
            {
                this.roomForCream = value;
            }
        }
        private bool decaf;
        /// <summary>
        /// Property to say if the customer wants their java decaf.
        /// </summary>
        public bool Decaf
        {
            get
            {
                return this.decaf;
            }
            set
            {
                this.decaf = value;
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
                switch (size)
                {
                    case Size.Small:
                        Price = 0.59;
                        Calories = 2;
                        break;
                    case Size.Medium:
                        Price = 0.99;
                        Calories = 4;
                        break;
                    case Size.Large:
                        Price = 1.49;
                        Calories = 8;
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
                ingredients.Add("Coffee");
                return ingredients;
            }
        }
        /// <summary>
        /// Create the coffee ith default size small, no ice, no room for cream, and not decaf
        /// </summary>
        public JurassicJava()
        {
            Size = Size.Small;
            RoomForCream = false;
            Decaf = false;
            Ice = false;
        }
        /// <summary>
        /// Sets RoomForCream to true
        /// </summary>
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        /// <summary>
        /// Puts ice in the drink.
        /// </summary>
        public void AddIce()
        {
            Ice = true;
        }
    }
}
