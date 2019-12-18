using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace OneTechStudentManagerService
{
    public class StudentRepository : IStudentRepository
    {
        private readonly MyContext _db = new MyContext();

        public List<Student> GetAllStudents()
        {
            return _db.Students.ToList();
        }
    }
}