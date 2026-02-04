using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day5_Interface.Services;
using Day5_Interface.Models;

namespace Day5_Interface.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        [HttpGet("GetStudents")]
        public List<StudentModel> GetStudents()
    {
        
    }

    [HttpPost("AddStudent")]
    public bool AddStudent(StudentModel studentToAdd)
    {
        
    }
    }
}