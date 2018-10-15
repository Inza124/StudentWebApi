using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentWebApi.Models;

namespace StudentWebApi.Services
{
    public class StudentService : IStudentServices
    {
        private readonly Dictionary<string, StudentModel> _students;

        public StudentService()
        {
            _students = new Dictionary<string, StudentModel>();
        }

        public StudentModel AddStudents(StudentModel students)
        {
            _students.Add(students.Name, students);
            return students;
        }

        public Dictionary<string, StudentModel> getStudents()
        {
            return _students;
        }
    }
}
