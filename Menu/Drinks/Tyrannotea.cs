using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public class Tyrannotea: Drink
    {
        private Size size;
        private bool sweet;
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
            }
        }
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
            }
        }
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
        public Tyrannotea()
        {
            Size = Size.Small;
            Sweet = false;
            Lemon = false;

        }
        public void AddLemon()
        {
            Lemon = true;
        }
    }
}
