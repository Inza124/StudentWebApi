using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;
using StudentWebApi.Services;

namespace StudentWebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        private readonly IStudentServices _service;

        public StudentController(IStudentServices services)
        {
            _service = services;
        }
        [HttpPost]
        [Route("AddStudents")]
        public ActionResult<StudentModel> AddStudents(StudentModel students)
        {
            var student = _service.AddStudents(students);
            if(student == null)
            {
                return NotFound();
            }
            return student;
        }

        [HttpGet]
        [Route("GetStudents")]
        public ActionResult<Dictionary<string, StudentModel>> GetStudents()
        {
            var students = _service.getStudents();
            if (students.Count == 0)
            {
                return NotFound();
            }
            return students;
        }
    }
}