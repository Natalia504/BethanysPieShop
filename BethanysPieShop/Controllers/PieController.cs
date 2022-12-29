using BethanysPieShop.Models;
using BethanysPieShop.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace BethanysPieShop.Controllers;

public class PieController : Controller
{
    // GET all pies
    private readonly IPieRepository _pieRepository;
    private readonly ICategoryRepository _categoryRepository;

    public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
    {
        // constructor Injection aka Dependency injection
        _pieRepository = pieRepository;
        _categoryRepository = categoryRepository;
    }

    public IActionResult List()
    {
        // ViewBag.CurrentCategory = "Cheese Cakes"; // setting value here to display in View, or do dynamicly 
        // return View(_pieRepository.AllPies); 
       PieListViewModel piesListViewModel = new PieListViewModel (_pieRepository.AllPies, "Cheese cakes");
       return View(piesListViewModel);
    }
} 