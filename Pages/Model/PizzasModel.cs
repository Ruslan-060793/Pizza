﻿using System;
namespace Pizzas.Pages.Model
{
	public class PizzasModel
	{
		public string ImageTitle { get; set;}
        public string PizzaName { get; set; }
        public int BasePrice { get; set; } = 2;
        public bool TomatoSauce { get; set; }
        public bool Cheese { get; set; }
        public bool Peperoni { get; set; }
        public bool Mushroom { get; set; }
        public bool Tune { get; set; }
        public bool Pineapple { get; set; }
        public bool Ham { get; set; }
        public float FinalPrice { get; set;}

	}
}

