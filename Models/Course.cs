using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementApplication.Models
{
    public class Course
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Please Provide Course Code")]
        [StringLength(20,MinimumLength = 5,ErrorMessage = "Course should be 5-20 characters long")]
        [Column(TypeName = "varchar")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Please provide course Name")]
        [StringLength(100,ErrorMessage = "Maximum length of Course Name is 100 character long")]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Please Provide Credit")]
        [Range(0.5,5.0,ErrorMessage = "Credit Should be 0.5 to 5.0")]
        public double Credit { get; set; }

        [Required(ErrorMessage = "Please add description")]
        [StringLength(500,ErrorMessage = "Maximum length is 500 characters")]
        [Column(TypeName = "varchar")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Please Select Department")]
        public int DepartmentId { get; set; }

        [Required(ErrorMessage = "Please add semester")]
        [Column(TypeName = "varchar")]
        [StringLength(100)]
        public string Semester { get; set; }

        public Department Department { get; set; }

    }
}