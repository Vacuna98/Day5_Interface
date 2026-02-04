using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services
{
    public interface IStudentService
    {
         public List<StudentModel> GetStudents();




    public bool AddStudent(StudentModel studentToAdd);
    }
}