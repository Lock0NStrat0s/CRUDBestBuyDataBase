using CRUDBestBuyDataBase.Repositories;
using Microsoft.AspNetCore.Mvc;

namespace CRUDBestBuyDataBase.Controllers;

public class ProductController : Controller
{
    private readonly IProductRepository repo;

    public ProductController(IProductRepository repo)
    {
        this.repo = repo;
    }

    // GET: /<controller>/
    public IActionResult Index()
    {
        var products = repo.GetAllProducts();
        return View(products);
    }
}
