using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Water: Drink
    {
        private bool lemon;
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
        public Water()
        {
            Size = Size.Small;
            Lemon = false;

        }
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
