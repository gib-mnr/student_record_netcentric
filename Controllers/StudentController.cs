using Microsoft.AspNetCore.Mvc;
using StudentRecord.Models;
using StudentRecord.Services;

namespace StudentRecord.Controllers
{
   
    public class StudentController : Controller
    {
        // Declare the static list inside the class
        // private static List<StudentModel> students = new List<StudentModel>();
        
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
        {
            _studentService = studentService;
        }
        
        
        [HttpGet]
        public IActionResult Create()
        {
            return View(); 
            // Displays the form to the user
       //     return View();  // Looks for Views/Student/Create.cshtml
         //   return View("Different");  // Looks for Views/Student/Different.cshtml
        }

        
        [HttpPost]
        public IActionResult Create(StudentModel student)
        {
            if (ModelState.IsValid)
            {
                _studentService.AddStudent(student);
                return RedirectToAction("Success");
                
                // student.Id = students.Count + 1;
                // students.Add(student);
                // In a real app, save the student data to a database here
                return RedirectToAction("Success");  // Browser goes to /Student/Success
                // return View("Success");  // Stays at /Student/Create but shows Success.cshtml
            }

            // If validation fails, redisplay the form with errors
            return View(student);
        }

        public IActionResult Success()
        {
            return View(); // Displays a success message
        }
        
        
        public IActionResult List()
        {
            var students  = _studentService.GetAllStudents();
            Console.WriteLine($"Number of students: {students.Count()}");

            return View(students);

            // return View(students);
        }
    }
    
}
