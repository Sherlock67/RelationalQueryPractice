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

        public Task<College> Create(College entity)
        {
            throw new NotImplementedException();
        }

        public void Delete(College entity)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<College> GetAll()
        {
            throw new NotImplementedException();
        }

        public College GetById(int Id)
        {
            throw new NotImplementedException();
        }

        public void Update(College entity)
        {
            throw new NotImplementedException();
        }
    }
}
