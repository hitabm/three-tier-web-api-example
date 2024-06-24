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
        public IActionResult All()
        {
            try
            {
                var alStudents = _studentService.GetStudents();
                return Ok(alStudents);
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPost]
        public async Task<IActionResult> Add([FromBody] StudentAddModel studentAddModel)
        {
            try
            {
                await _studentService.AddStudent(studentAddModel);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpPut]
        public IActionResult Update([FromBody] StudentUpdateModel studentUpdateModel)
        {
            try
            {
                _studentService.UpdateStudent(studentUpdateModel);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            try
            {
                _studentService.DeleteStudent(id);
                return Ok();
            }
            catch
            {
                return StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}
