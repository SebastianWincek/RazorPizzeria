using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPizzeria.Models;

namespace RazorPizzeria.Pages
{
    public class PizzaModel : PageModel
    {
        public List<PizzasModel> FakePizzaDb = new List<PizzasModel>()
        {
            new PizzasModel()
            {
                ImageTilte = "Margerita",
                PizzaName = "Margerita",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                FinalPrice = 4
            },
            new PizzasModel()
            {
                ImageTilte = "Bolognese",
                PizzaName = "Bolognese",
                BasePrice = 2,
                TomatoSauce = true,
                Cheese = true,
                Beef = true,
                FinalPrice = 6
            },
            new PizzasModel()
            {
                ImageTilte = "Carbonara",
                PizzaName = "Carbonara",
                BasePrice = 2,
                Cheese = true,
                Ham = true,
                FinalPrice = 4
            },
        };
        public void OnGet()
        {
        }
    }
}
