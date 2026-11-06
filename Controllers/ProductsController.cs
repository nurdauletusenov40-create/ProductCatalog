using Microsoft.AspNetCore.Mvc;
using ProductCatalog.Models;

namespace ProductCatalog.Controllers;

public class ProductsController : Controller
{
    private static readonly List<Product> Products =
    [
        new() { Id = 1, Name = "Apple MacBook Air", Price = 599990m, Category = "Компьютерлік техника", IsAvailable = true, ImageUrl = "/images/macbook-air.jpg" },
        new() { Id = 2, Name = "iPhone 15", Price = 449990m, Category = "Электроника", IsAvailable = true, ImageUrl = "/images/iphone-15.jpg" },
        new() { Id = 3, Name = "Samsung Galaxy S24", Price = 389990m, Category = "Электроника", IsAvailable = true, ImageUrl = "/images/samsung-galaxy.jpg" },
        new() { Id = 4, Name = "Sony WH-1000XM5", Price = 189990m, Category = "Аксессуарлар", IsAvailable = false, ImageUrl = "/images/sony-headphones.jpg" },
        new() { Id = 5, Name = "Gaming Keyboard Pro", Price = 54990m, Category = "Аксессуарлар", IsAvailable = true, ImageUrl = "/images/gaming-keyboard.jpg" },
        new() { Id = 6, Name = "Apple Watch Series 9", Price = 229990m, Category = "Смарт құрылғылар", IsAvailable = true, ImageUrl = "/images/smart-watch.jpg" },
        new() { Id = 7, Name = "Logitech MX Master 3S", Price = 49990m, Category = "Аксессуарлар", IsAvailable = true, ImageUrl = "/images/wireless-mouse.jpg" },
        new() { Id = 8, Name = "Gaming Monitor UltraWide", Price = 319990m, Category = "Компьютерлік техника", IsAvailable = false, ImageUrl = "/images/gaming-monitor.jpg" }
    ];

    public IActionResult Index(string? search, string? category)
    {
        var products = Products.AsEnumerable();

        if (!string.IsNullOrWhiteSpace(search))
        {
            products = products.Where(product =>
                product.Name.Contains(search.Trim(), StringComparison.CurrentCultureIgnoreCase));
        }

        if (!string.IsNullOrWhiteSpace(category) && category != "Барлығы")
        {
            products = products.Where(product =>
                product.Category.Equals(category, StringComparison.CurrentCultureIgnoreCase));
        }

        ViewBag.Title = "Технологиялар әлеміне қош келдіңіз!";
        ViewBag.ProductCount = Products.Count;
        ViewBag.AvailableCount = Products.Count(product => product.IsAvailable);
        ViewBag.CategoryCount = Products.Select(product => product.Category).Distinct().Count();
        ViewBag.Categories = Products.Select(product => product.Category).Distinct().ToList();
        ViewBag.Search = search ?? string.Empty;
        ViewBag.SelectedCategory = category ?? string.Empty;

        return View(products.ToList());
    }

    public IActionResult Details(int id)
    {
        var product = Products.FirstOrDefault(item => item.Id == id);
        return product is null ? NotFound() : View(product);
    }

    public IActionResult Error()
    {
        return View();
    }
}
