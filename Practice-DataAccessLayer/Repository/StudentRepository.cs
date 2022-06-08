using Practice_DataAccessLayer.Data;
using Practice_DataAccessLayer.Interface;
using Practice_DataAccessLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataAccessLayer.Repository
{
    public class StudentRepository : IStudent
    {
        public readonly ApplicationDbContext _db;

        public StudentRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<Student> Create(Student entity)
        {
            var obj = await _db.students.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;

        }

        public void Delete(Student entity)
        {
            _db.students.Remove(entity);
            _db.SaveChanges();
        }

        public IEnumerable<Student> GetAll()
        {
            try
            {
               return _db.students.ToList();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public Student GetById(int Id)
        {

            return _db.students.Where(u => u.StudentID == Id).FirstOrDefault();
            //throw new NotImplementedException();
        }

        public void Update(Student entity)
        {
            _db.students.Update(entity);
            _db.SaveChanges();
           
        }




        //public Student GetStudentById(int Id)
        //{
            
        //}

        public Task<Student> GetStudentById(int Id)
        {
            College college = new College();
            return  (from p in _db.colleges
                    join o in _db.students on p.CollegeID equals o.CollegeID
                    where college.CollegeID == Id
                    select new
                    {
                        o.StudentID,
                        o.StudentName
                    });
           
           
            //   throw new NotImplementedException();
        }
    }
}
