using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu.Drinks
{
    public enum Size
    {
        Small,
        Medium,
        Large
    }
    public abstract class Drink
    {
        public abstract List<string> Ingredients { get; }
        public double Price { get; set; }
        public uint Calories { get; set; }
        public bool Ice { get; set; } = true;
        public abstract Size Size { get; set; }
        public virtual void HoldIce()
        {
            Ice = false;
        }


    }
}
