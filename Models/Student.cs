using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MvcStudent.Models
{
    public class Student
    {

        [Key]
        public int IdStudent { get; set; }
        public string StudentName { get; set; }
        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }
        [Required(ErrorMessage = "DiaChi is Required")]
        [StringLength(15, MinimumLength = 3)]
        public string DiaChi { get; set; }
        [EmailAddress]
        public string Email { get; set;}

    }
}