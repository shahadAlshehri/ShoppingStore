using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ShoppingProject.Models;

namespace ShoppingProject.Controllers
{
    public class ProductsController : Controller
    {

            List<ProductModel> Products = new List<ProductModel>()
            {
                new ProductModel(){Id=1, Name="Dress", price=300, Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcStQx9wQUCfXoGXjG_kyWlZp1iJOmYHE3JBIw&usqp=CAU"},
                new ProductModel(){Id=2, Name="T-shrit", price=130,Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSTuq1Ta18AGsAbksJD-banNswrZNhWUFkG0Q&usqp=CAU"},
                new ProductModel(){Id=3, Name="Shose", price=330,Image = "https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcSCpg2UzMifBFq7RBIRNMMDINeLcbH7bbrkIw&usqp=CAU"},
                new ProductModel(){Id=4,Name="Necklace",price=56,Image="data:image/jpeg;base64,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"}
            };
        public IActionResult Index(string color="white")
        {
            ViewData["color"] = color;

            foreach (var item in Products) { 
            }
            ViewData["color"] = color;
            ViewData["Products"] = Products;
            return View();
        }

        public IActionResult Details(int? id)// to rserve null
        {
            ProductModel product = Products.Find(p => p.Id == id);
            if (product == null)
            {
                return Content("Not found your product");

               // return RedirectToAction("Index", "error");

            }
            else
            {
                ViewData["products"] = product;
                return View();
            }
           

        }

        public IActionResult Random()
        {
            return View();
        }
    }
}
