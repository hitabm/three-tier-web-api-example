using Microsoft.AspNetCore.Mvc;
using StudentExample.BLL.Models;
using StudentExample.BLL.Services;

namespace StudentExample.PL.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class StudentController(StudentService studentService) : ControllerBase
    {
        private readonly StudentService _studentService = studentService;

        [HttpGet]
        public IActionResult AllStudents()
        {
            var alStudents = _studentService.GetStudents();
            return Ok(alStudents);
        }

        [HttpPost]
        public async Task<IActionResult> AddStudent([FromBody] StudentAddModel studentAddModel)
        {
            await _studentService.AddStudent(studentAddModel);
            return Ok();
        }
    }
}
