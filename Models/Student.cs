using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models
{
    public class Student
    {

        [Key]
        public int IdStudent { get; set; }
        public string StudentName { get; set; }
        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }
        [Required(ErrorMessage = "StudentName is Required")]
        [MaxLength(15)]
        [MinLength(3)]
        public string DiaChi { get; set; }

    }
}