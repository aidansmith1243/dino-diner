using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class JurassicJava: Drink
    {
        private bool roomForCream;
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
        public JurassicJava()
        {
            Size = Size.Small;
            RoomForCream = false;
            Decaf = false;
            Ice = false;
        }
        public void LeaveRoomForCream()
        {
            RoomForCream = true;
        }
        public void AddIce()
        {
            Ice = true;
        }
    }
}
