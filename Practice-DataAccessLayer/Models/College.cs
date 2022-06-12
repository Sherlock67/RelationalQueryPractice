using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practice_DataAccessLayer.Models
{
    public class College
    {
        [Key]
        public int CollegeID { get; set; }

        public string CollegeName { get; set; }

        
    }
}
