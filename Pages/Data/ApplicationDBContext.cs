using System;
using Microsoft.EntityFrameworkCore;
using Pizza.Pages.Model;

namespace Pizza.Pages.Data
{
	public class ApplicationDBContext: DbContext
	{
		public DbSet<PizzaOrder> PizzaOrders { get; set; }

		public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options): base()
		{

		}
	}
}

