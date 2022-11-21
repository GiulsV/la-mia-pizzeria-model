using la_mia_pizzeria_model.Models;
using la_mia_pizzeria_model.Data;
using Microsoft.AspNetCore.Mvc;

namespace la_mia_pizzeria_model.Controllers
{
    public class PizzaController : Controller
    {
        public IActionResult Index()
        {

            PizzeriaDbContext db = new PizzeriaDbContext();

            List<Pizza> listaPizze = db.Pizze.ToList();
            return View(listaPizze);
        }

        public IActionResult Detail(int id)
        {
            PizzeriaDbContext db = new PizzeriaDbContext();

            Pizza pizza = db.Pizze.Where(pizza => pizza.Id == id).FirstOrDefault();

            return View(pizza);
        }
    }
}
