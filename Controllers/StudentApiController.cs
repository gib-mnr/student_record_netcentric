
using Microsoft.AspNetCore.Mvc;
using StudentRecord.Models;
using StudentRecord.Services;

namespace StudentRecord.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentApiController : ControllerBase
    {
        private readonly IStudentService _studentService;

        public StudentApiController(IStudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult AddStudent([FromBody] StudentModel student)
        {
            if (ModelState.IsValid)
            {
                _studentService.AddStudent(student);
                return CreatedAtAction(nameof(GetStudents), new { id = student.Id }, student);
            }
            return BadRequest(ModelState);
        }
    }
}

// Add project to git