using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using SuperMarket.Models;

namespace SuperMarket.Controllers
{
    public class CategoriesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Edit(int id)
        {
            var myCatagory = new CategoriesModel { CategoryID = id};
            return View(myCatagory);
        }
    }
}
