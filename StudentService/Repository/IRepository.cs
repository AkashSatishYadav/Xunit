using StudentService.Models;

namespace StudentService.Repository
{
    public interface IRepository
    {
        IEnumerable<Student> GetAll();
        Student GetByRollNo(int rollNo );
    }
}
