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
