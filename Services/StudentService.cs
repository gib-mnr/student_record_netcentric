using StudentRecord.Models;

namespace StudentRecord.Services;

public class StudentService : IStudentService
{
    private readonly List<StudentModel> _students = new();

    public void AddStudent(StudentModel student)
    {
        
        student.Id = _students.Count + 1;
        _students.Add(student);
    }

    public IEnumerable<StudentModel> GetAllStudents()
    {
        return _students;
    }
}