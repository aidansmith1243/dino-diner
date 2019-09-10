using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Entrees
{
    public class Brontowurst
    {
        private bool peppers = true;
        private bool onion = true;
        private bool bun = true;

        public double Price { get; set; }

        public uint Calories { get; set; }

        public List<string> Ingredients
        {
            get
            {
                List<string> ingredients = new List<string>() {"Brautwurst"};
                if (bun) ingredients.Add("Whole Wheat Bun");
                if (onion) ingredients.Add("Onion");
                if (peppers) ingredients.Add("Peppers");
                return ingredients;
            }
        }
        public Brontowurst()
        {
            this.Price = 5.36;
            this.Calories = 498;
        }
        public void HoldBun()
        {
            this.bun = false;
        }
        public void HoldPeppers()
        {
            this.peppers = false;
        }
        public void HoldOnion()
        {
            this.onion = false;
        }

    }
}
