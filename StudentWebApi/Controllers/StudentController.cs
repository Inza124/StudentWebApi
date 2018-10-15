using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using StudentWebApi.Models;

namespace StudentWebApi.Controllers
{
    [Route("api/")]
    [ApiController]
    public class StudentController : ControllerBase
    {
        [HttpPost]
        public ActionResult<StudentModel> AddStudentItems(StudentModel students)
        {
            var student = _service.AddStudents(students);
            if(student == null)
            {
                return NotFound();
            }
            return student;
        }
    }
}