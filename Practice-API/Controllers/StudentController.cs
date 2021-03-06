using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_BusinessLayer.Services;
using Practice_DataAccessLayer.Models;

namespace Practice_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpPost("AddStudent")]
        public async Task<Object> CreateNewStudent([FromBody] Student student)
        {
            try
            {
                await _studentService.CreateStudent(student);
                return true;

            }
            catch (Exception ex)
            {
                return false;
            }
        }
        [HttpGet("GetAllStudentsByCollege")]
        public Student GetStudents(int Id)
        {
            try
            {
                return _studentService.GetAllStudentsByCollege(Id);
                
                // some service call will be here.
                //await _studentService 

            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
