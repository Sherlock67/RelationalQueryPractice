using Practice_DataAccessLayer.Interface;
using Practice_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_BusinessLayer.Services
{
    public class StudentService
    {
        public readonly IStudent _student;
        public StudentService(IStudent student)
        {
            _student = student;
        }
        public async Task<Student> CreateStudent(Student student)
        {
            return await _student.Create(student);
        }

        public Task<Student> GetAllStudentsByCollege(int Id)
        {
            return _student.GetStudentById(Id);

        }
    }
}
