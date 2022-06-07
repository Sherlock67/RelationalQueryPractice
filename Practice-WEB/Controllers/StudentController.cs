using Microsoft.AspNetCore.Mvc;
using Practice_DataAccessLayer.Models;

namespace Practice_WEB.Controllers
{
    public class StudentController : Controller
    {
        public IActionResult AddNewStudent()
        {
            return View();
        }

        public async Task<IActionResult> AddNewStudent(Student student)
        {

            return View();
        }
    }
}
