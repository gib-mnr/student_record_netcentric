
// Controller for managing student-related actions
using Microsoft.AspNetCore.Mvc;
using StudentRecord.Models;


namespace StudentRecord.Controllers;

public class NewStudentController : Controller
{
    
    // Handles GET requests for the Index view
   [HttpGet]
    public IActionResult Index()
    {
        return View(); // Returns the default view associated with this action

    }

    [HttpPost]
    public IActionResult Index(NewStudentModel student)
    {
        return RedirectToAction("Success");
        
            // return View();
    }

    public IActionResult Success()
    {
        return View();
    }
}