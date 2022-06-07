using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Practice_BusinessLayer.Services;
using Practice_DataAccessLayer.Models;

namespace Practice_API.Controllers
{
    [Route("api/v1/[controller]")]
    [ApiController]
    public class CollegeController : ControllerBase
    {
        private readonly CollegeService _collegeService;

        public CollegeController(CollegeService collegeService)
        {
            _collegeService = collegeService;
        }
        [HttpPost("AddCollege")]

        public async Task<Object> CreateNewCollege([FromBody] College college)
        {
            try
            {
                await _collegeService.CreateCollege(college);
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }

        }
    }
}
