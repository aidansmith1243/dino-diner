using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using DinoDiner.Menu;

namespace Website.Pages
{
    public class MenuModel : PageModel
    {
        public Menu menu;
        public List<IMenuItem> FullMenu;
        [BindProperty]
        public string search { get; set; } = "";
        [BindProperty]
        public List<string> menuCategory { get; set; } = new List<string>();
        [BindProperty]
        public double? minimumPrice { get; set; }
        [BindProperty]
        public double? maximumPrice { get; set; }
        [BindProperty]
        public List<string> IngredientsCategory { get; set; } = new List<string>();

        public void OnGet()
        {
            
            menu = new Menu();
            FullMenu = menu.AvailableMenuItems;
        }

        public void OnPost(string search, List<string> menuCategory, double? minimumPrice, double? maximumPrice, List<string> ingredientsCategory)
        {
            menu = new Menu();
            FullMenu = menu.AvailableMenuItems;
            FullMenu = Menu.FilterByName(FullMenu,search);
            FullMenu = Menu.FilterByType(FullMenu, menuCategory);
            FullMenu = Menu.FilterByPrice(FullMenu, minimumPrice, maximumPrice);
            FullMenu = Menu.FilterByExcludedIngredients(FullMenu, ingredientsCategory);

        }

        public string GetIngredients(IMenuItem m)
        {
            string str = "Ingredients: ";
            foreach(string i in m.Ingredients)
            {
                str += i + ", ";
            }
            return str.Substring(0, str.Length - 2); 
        }
    }
}