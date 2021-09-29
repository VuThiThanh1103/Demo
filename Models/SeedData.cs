using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcStudent.Data;
using System;
using System.Linq;

namespace MvcStudent.Models
{
    public static class SeedData
    {
        public static void Initialize(IServiceProvider serviceProvider)
        {
            using (var context = new MvcStudentsContext(
                serviceProvider.GetRequiredService<
                    DbContextOptions<MvcStudentsContext>>()))
            {
                // Look for any movies.
                if (context.Student.Any())
                {
                    return;   // DB has been seeded
                }

                context.Student.AddRange(
                    new Student
                    {
                        IdStudent = 1103,
                        StudentName = "Vũ Thị Thanh",
                        NamSinh = DateTime.Parse("2000-06-29"),
                        DiaChi = "Nam Định",
                        Email  = "vuthanh2906@gmail.com"
                    },

                    new Student
                    {
                        IdStudent = 0668,
                        StudentName ="Nguyễn Thị Hương",
                        NamSinh = DateTime.Parse("2000-08-14"),
                        DiaChi = "Hà Nam",
                        Email  = "huongnguyen@gmail.com"
                    },

                    new Student
                    {
                        IdStudent = 0578,
                        StudentName ="Hoàng Hải Yến",
                        NamSinh = DateTime.Parse("2000-09-25"),
                        DiaChi = "Quảng Ninh",
                        Email  = "haiyen@gmail.com"
                    },

                    new Student
                    {
                        IdStudent = 0975,
                        StudentName ="Phạm Tiến Đạt",
                        NamSinh = DateTime.Parse("1999-01-05"),
                        DiaChi = "Ninh Bình",
                        Email  = "tiendat@gmail.com"
                    }
                );
                context.SaveChanges();
            }
        }
    }
}