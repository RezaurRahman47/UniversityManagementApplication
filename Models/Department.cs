using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementApplication.Models
{
    public class Department
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please provide Department Code")]
        [StringLength(7,MinimumLength = 3,ErrorMessage = "Department code should be 3-7 characters long")]
        [DisplayName("Department Code")]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }
        [Required(ErrorMessage = "Please provide Department Name")]
        [DisplayName("Department Name")]
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Name { get; set; }


        public List<Course> Courses { get; set; }

        public List<Teacher> Teachers { get; set; }

        public List<Student> Students { get; set; }



    }
}