using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataAccessLayer.Models
{
    public class Student
    {
        [Key]
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        //public int StudentAge { get; set; }
        [ForeignKey("College")]
        public int CollegeID {get; set;}
        //public College College {get; set;}
        public  College Colleges { get; set; }
        // public College Colleges { get; set; }
    }
}
