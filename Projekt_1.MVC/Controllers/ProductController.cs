using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Projekt_1.MVC.Models;
using Projekt_1.MVC.Services;

namespace Projekt_1.MVC.Controllers
{
    public class ProductController : Controller
    {
        private readonly ProductService productService;
        public ProductController()
        {
            productService = new ProductService();
        }
        // GET: ProductController
        [Route("")]
        public ActionResult Index()
        {
            var products=productService.GetAll();
            return View(products);
        }

        // GET: ProductController/Details/5
        [Route("details/{id:int}")]
        public ActionResult Details(int id)
        {
            var products = productService.GetById(id);
            return View(products);
        }

        // GET: ProductController/Create
        [Route("create")]
        public ActionResult Create()
        {

            return View();
        }

        // POST: ProductController/Create
        [Route("create")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Product product)
        {
            productService.Create(product);
            TempData["Success"] = "Product added.";
            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Edit/5
        [Route("edit/{id:int}")]
        public ActionResult Edit(int id)
        {
            var product=productService.GetById(id);
            return View(product);
        }

        // POST: ProductController/Edit/5
        [Route("edit/{id:int}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, Product product)
        {
            productService.Update(product);

            return RedirectToAction(nameof(Index));
        }

        // GET: ProductController/Delete/5
        [Route("delete/{id:int}")]
        public ActionResult Delete(int id)
        {
            var product= productService.GetById(id);
            return View(product);
        }

        // POST: ProductController/Delete/5
        [Route("delete/{id:int}")]
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Product product)
        {
            productService.Delete(id);
            TempData["Delete"] = "Product deleted.";
            return RedirectToAction(nameof(Index));
        }
    }
}
