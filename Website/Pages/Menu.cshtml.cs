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
        public void OnGet()
        {
            menu = new Menu();
            
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