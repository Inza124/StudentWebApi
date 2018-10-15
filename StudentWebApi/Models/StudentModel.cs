using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudentWebApi.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public String Name { get; set; }
        public String City { get; set; }
        public String Department { get; set; }
    }
}
