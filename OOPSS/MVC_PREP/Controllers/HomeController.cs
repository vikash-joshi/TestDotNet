using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using MVC_PREP.Models;

namespace MVC_PREP.Controllers;

public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult Create()
    {
        ViewData["Message"] = "Hello from ViewData!";
        ViewBag.Message = "Hello from ViewBag!";
        TempData["Alert"] = "This is a TempData alert!";
        var model = new Student
        {
            Name = "John Doe",
            Age = 20,
            Email = "echovik"
        };
        return View(model);
    }

    [HttpPost]
    public IActionResult Create(Student student)
    {
        
        System.Console.WriteLine(student.Name);
        System.Console.WriteLine(student.Age);
        System.Console.WriteLine(student.Email);
        if (ModelState.IsValid)
        {
           
        
            // Save the student to the database or perform other actions
            _logger.LogInformation("Student created: {Name}", student.Name);
            ViewData["SuccessMessage"] = "Student created successfully!";
            
        }
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
