using StudentService.Models;

namespace StudentService.Repository
{
    public class StudentRepository : IRepository
    {
        public IEnumerable<Student> GetAll()
        {
            return GetStudents();
        }

        public Student GetByRollNo(int rollNo)
        {
            return GetStudents().Find(x => x.RollNo == rollNo);
        }
        
        List<Student> GetStudents()
        {
            var students = new List<Student>();
            students.Add(new Student() { FirstName = "Bruce", LastName = "Baner", RollNo = 39 });
            students.Add(new Student() { FirstName = "Bruce", LastName = "Wayne", RollNo = 19 });
            students.Add(new Student() { FirstName = "Clerk", LastName = "Kent", RollNo = 1 });
            students.Add(new Student() { FirstName = "Harry", LastName = "Potter", RollNo = 5 });
            return students;
        }
    }
}
