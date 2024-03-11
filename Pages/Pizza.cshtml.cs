using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Pizzas.Pages.Model;

namespace Pizza.Pages
{
	public class Pizza1Model : PageModel
    {
        public List<PizzasModel> fakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel(){
                ImageTitle = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true
            },

            new PizzasModel(){
                ImageTitle = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true
            },

            new PizzasModel(){
                ImageTitle = "Mushroom",
                PizzaName = "Mushroom",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true
            }
        };


        public void OnGet()
        {
        }
    }
}
