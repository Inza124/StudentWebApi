using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using StudentWebApi.Models;

namespace StudentWebApi.Services
{
    public interface IStudentServices
    {
        StudentModel AddStudents(StudentModel students);
        Dictionary<string, StudentModel> getStudents();
    }
}
