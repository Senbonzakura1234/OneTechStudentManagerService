using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace OneTechStudentManagerService
{
    public class MyContext : DbContext
    {
        public MyContext() : base("name=MyContext")
        {

        }
        public DbSet<Student> Students { get; set; }
    }
}