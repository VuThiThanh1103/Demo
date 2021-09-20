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
        public string DiaChi { get; set; }

    }
}