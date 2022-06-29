using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentService.Models;
using StudentService.Repository;

namespace StudentService.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    public class StudentController : Controller
    {
        IRepository _repo;
        public StudentController(IRepository repo)
        {
            _repo = repo;
        }
        [HttpGet]
        [Route("GetStudent")]
        public ActionResult<IEnumerable<Student>> GetStudents()
        {
            var model = _repo.GetAll();
            return Ok(model);
        }

        [HttpGet("GetStudentByRollNo/{rollNo}")]
        public ActionResult<Student> GetStudentByRollNo(int rollNo)
        {
            Student student = _repo.GetByRollNo(rollNo);
            if (student == null)
            {
                return NotFound("The Student record couldn't be found.");
            }
            return Ok(student);
        }
    }
}
