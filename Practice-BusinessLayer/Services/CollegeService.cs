using Practice_DataAccessLayer.Interface;
using Practice_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_BusinessLayer.Services
{
    public class CollegeService
    {
        public readonly ICollege _college;
        public CollegeService(ICollege college)
        {
            _college = college;
        }
        public async Task<College> CreateCollege(College college)
        {
            return await _college.Create(college);
        }

    }
}
