using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class TeacherController : ApiController
    {
        public Teacher Get(int id)
        {
            List<Student> students = new List<Student>();
            for (int i = 0; i < 10; i++)
            {
                students.Add(new Student
                {
                    Id = i,
                    Name = "Student" + i
                });
            }

            Teacher teacher = new Teacher
            {
                Id = 1,
                Name = "Teacher",
                Students = students

            };

            return teacher;
        }

    }
}
