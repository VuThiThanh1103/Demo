using System;
using System.ComponentModel.DataAnnotations;

namespace MvcStudent.Models
{
    public class GiaoVien
    {
        [Key]
        public int MaGV { get; set; }
        public string TenGV { get; set; }

        [DataType(DataType.Date)]
        public DateTime NamSinh { get; set; }
        public string DiaChi { get; set; }

    }
}