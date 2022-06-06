using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataAccessLayer.Models
{
    public class College
    {
        public int CollegeID { get; set; }

        public string CollegeName { get; set; }

        public int StudentID { get; set; }
        public Student Student { get; set; }
    }
}
