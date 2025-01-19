using StudentRecord.Models;

namespace StudentRecord.Services;

public interface IStudentService
{
    void AddStudent(StudentModel student);
    IEnumerable<StudentModel> GetAllStudents();
    
    
}