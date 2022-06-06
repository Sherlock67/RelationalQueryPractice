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
    public class CollegeRepository : ICollege
    {
        public readonly ApplicationDbContext _db;

        public CollegeRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public async Task<College> Create(College entity)
        {
            var obj = await _db.colleges.AddAsync(entity);
            _db.SaveChanges();
            return obj.Entity;
           
        }

        public void Delete(College entity)
        {
           _db.Remove(entity);
            _db.SaveChanges();
        }

        public IEnumerable<College> GetAll()
        {
            try
            {
                return _db.colleges.ToList();
            }
            catch(Exception e)
            {
                throw e;
            }
        }

        public College GetById(int Id)
        {
            return _db.colleges.Where(x => x.CollegeID == Id).FirstOrDefault();
           // throw new NotImplementedException();
        }

        public void Update(College entity)
        {
            _db.colleges.Update(entity);
            _db.SaveChanges();
            //throw new NotImplementedException();
        }
    }
}
