using la_mia_pizzeria_model.Models;
using la_mia_pizzeria_model.Data;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        PizzeriaDbContext db;

        public PizzaController() : base()
        {
            db = new PizzeriaDbContext();
        }
        public IActionResult Index()
        {
            List<Pizza> listaPizze = db.Pizze.ToList();
            return View(listaPizze);
        }

        public IActionResult Detail(int id)
        {
            Pizza pizza = db.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();
            if (pizza == null)
                return View("Errore", "Pizza non trovata");

            return View(pizza);

        }
    }
}
