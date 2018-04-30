using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace UniversityManagementApplication.Models
{
    public class Student
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "Please Provide Student Name")]
        [StringLength(100)]
        [Column(TypeName = "varchar")]
        public string Name { get; set; }
        [Required(ErrorMessage = "Please Provide Email address")]
        [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "example@mail.com")]
        [Column(TypeName = "varchar")]
        [StringLength(150)]
        public string Email { get; set; }
        [Required(ErrorMessage = "Please Provide Contact No")]
        [DisplayName("Contact No.")]
        [Range(11, 13, ErrorMessage = "Your no is not valid")]
        public int ContactNo { get; set; }
        [Required(ErrorMessage = "Please Provide Date")]
        public DateTime Date { get; set; }
        [Required(ErrorMessage = "Please Provide Address")]
        [StringLength(500)]
        [Column(TypeName = "varchar")]
        public string Address { get; set; }
        [Required(ErrorMessage = "Please Select Department")]
        [DisplayName("Department")]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

    }
}