using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataAccessLayer.Models
{
    public class Student
    {
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        //public int StudentAge { get; set; }
        public int CollegeID { get; set; }
        public College College { get; set; }
    }
}
