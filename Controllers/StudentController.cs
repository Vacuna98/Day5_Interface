using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Day5_Interface.Services;
using Day5_Interface.Models;
using System.Data;

namespace Day5_Interface.Controllers;

    [ApiController]
    [Route("api/[controller]")]
    public class StudentController : ControllerBase
    {
        
        private readonly IStudentService _studentService;

        public StudentController(IStudentService studentService)
    {
        _studentService = studentService;
    }

    //Read All
    [HttpGet("getStudentList")]
    public List<StudentModel> GetStudents()
    {
        return _studentService.GetStudents();
    }

    //Read by Id
    [HttpPost("GetStudentById/{id}")]
    public StudentModel? GetStudentById(int id)
    {
        return _studentService.GetStudentById(id);
    }

    //Create
    [HttpPost("AddStudent")]
    public StudentModel AddStudent(StudentModel student)
    {
        return _studentService.AddStudent(student);
    }

    //Update
    [HttpPut("updateStudent/{id}")]
    public StudentModel? UpdateStudent(int id, StudentModel student)
    {
        return _studentService.UpdateStudent(id, student);
    }

    //Delete
    [HttpDelete("removeStudent/{id}")]
    public bool DeleteStudent(int id)
    {
        return _studentService.DeleteStudent(id);
    }


    }
