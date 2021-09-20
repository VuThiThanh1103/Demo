using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcStudent.Models;

    public class MvcStudentsContext : DbContext
    {
        public MvcStudentsContext (DbContextOptions<MvcStudentsContext> options)
            : base(options)
        {
        }

        public DbSet<MvcStudent.Models.Student> Student { get; set; }

        public DbSet<MvcStudent.Models.GiaoVien> GiaoVien { get; set; }
    }
