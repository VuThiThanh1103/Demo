using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace MvcStudent.Models
{
    public class StudentGenreViewModel
    {
        public List<Student> Students { get; set; }
        public SelectList DiaChi { get; set; }
        public string StudentGenre { get; set; }
        public string SearchString { get; set; }
    }
}