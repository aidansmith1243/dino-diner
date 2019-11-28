/*
 * Menu.cs
 * Author: Aidan Smith
 */
using System;
using System.Collections.Generic;
using System.Text;

namespace DinoDiner.Menu
{
    /// <summary>
    /// This class is used to see all of the menu items that we have.
    /// </summary>
    public class Menu
    {
        public static List<IMenuItem> FilterByName(List<IMenuItem> menu, string name)
        {
            if (name == null || name.Equals("")) return menu;
            List<IMenuItem> newMenu = new List<IMenuItem>();
            foreach(IMenuItem m in menu)
            {
                if (m.ToString().ToLower().Contains(name.ToLower()))
                {
                    newMenu.Add(m);
                }
            }
            return newMenu;
            
        }
        public static List<IMenuItem> FilterByType(List<IMenuItem> menu, List<string> type)
        {
            if (type == null || type.Count == 0) return menu;
            List<IMenuItem> newMenu = new List<IMenuItem>();
            foreach (IMenuItem m in menu)
            {
                if (m is CretaceousCombo && type.Contains("Combo")) newMenu.Add(m);
                else if (m is Drink && type.Contains("Drink")) newMenu.Add(m);
                else if (m is Side && type.Contains("Side")) newMenu.Add(m);
                else if (m is Entree && type.Contains("Entree")) newMenu.Add(m);
            }
            return newMenu;
        }
        public static List<IMenuItem> FilterByPrice(List<IMenuItem> menu, double? min, double? max)
        {
            if (min == null && max == null) return menu;
            if (min == null) min = double.MinValue;
            if (max == null) max = double.MaxValue;
            List<IMenuItem> newMenu = new List<IMenuItem>();
            foreach (IMenuItem m in menu)
            {
                if (!(m.Price < min) && !(m.Price > max))
                {
                    newMenu.Add(m);
                }
            }
            return newMenu;
        }
        public static List<IMenuItem> FilterByExcludedIngredients(List<IMenuItem> menu, List<string> ingredients)
        {
            if (ingredients == null || ingredients.Count == 0) return menu;

            List<IMenuItem> newMenu = new List<IMenuItem>();
            foreach (IMenuItem m in menu)
            {
                bool contains = false;
                foreach (string i in ingredients)
                    if (m.Ingredients.Contains(i))
                        contains = true;
                if (!contains)
                    newMenu.Add(m);
            }
            return newMenu;

        }
        public List<string> PossibleIngredients
        {
            get
            {
                List<string> items = new List<string>();
                foreach(IMenuItem m in AvailableMenuItems)
                {
                    foreach(string i in m.Ingredients)
                    {
                        if (!items.Contains(i))
                            items.Add(i);
                    }
                }
                return items;
            }
        }

        /// <summary>
        /// Shows all of the items on the menu
        /// </summary>
        public List<IMenuItem> AvailableMenuItems
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.AddRange(AvailableCombos);
                items.AddRange(AvailableEntrees);
                items.AddRange(AvailableSides);
                items.AddRange(AvailableDrinks);
                return items;
            }
        }
        /// <summary>
        /// Shows all of the entrees
        /// </summary>
        public List<IMenuItem> AvailableEntrees
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Brontowurst());
                items.Add(new DinoNuggets());
                items.Add(new PrehistoricPBJ());
                items.Add(new PterodactylWings());
                items.Add(new SteakosaurusBurger());
                items.Add(new TRexKingBurger());
                items.Add(new VelociWrap());
                return items;
            }
        }
        /// <summary>
        /// Shows all of the Sides
        /// </summary>
        public List<IMenuItem> AvailableSides
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new Fryceritops());
                items.Add(new MeteorMacAndCheese());
                items.Add(new MezzorellaSticks());
                items.Add(new Triceritots());
                return items;
            }
        }
        /// <summary>
        /// Shows all of the drinks
        /// </summary>
        public List<IMenuItem> AvailableDrinks
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new JurassicJava());
                items.Add(new Sodasaurus());
                items.Add(new Tyrannotea());
                items.Add(new Water());
                return items;
            }
        }
        /// <summary>
        /// Shows all of the combos
        /// </summary>
        public List<IMenuItem> AvailableCombos
        {
            get
            {
                List<IMenuItem> items = new List<IMenuItem>();
                items.Add(new CretaceousCombo(new Brontowurst()));
                items.Add(new CretaceousCombo(new DinoNuggets()));
                items.Add(new CretaceousCombo(new PrehistoricPBJ()));
                items.Add(new CretaceousCombo(new PterodactylWings()));
                items.Add(new CretaceousCombo(new SteakosaurusBurger()));
                items.Add(new CretaceousCombo(new TRexKingBurger()));
                items.Add(new CretaceousCombo(new VelociWrap()));
                return items;
            }
        }
        /// <summary>
        /// Gives all of the menu items as a string on different lines.
        /// </summary>
        /// <returns>string</returns>
        public override string ToString()
        {
            List<IMenuItem> items = AvailableMenuItems;
            StringBuilder sb = new StringBuilder();
            foreach(IMenuItem x in items)
            {
                sb.Append(x.ToString());
                sb.AppendLine();
            }
            return sb.ToString();
        }
    }
    
}
