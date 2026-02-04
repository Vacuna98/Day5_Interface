using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services
{
    public interface IStudentService
    {
         StudentModel AddStudent (StudentModel newStudent); //CREATE

         public List<StudentModel> GetStudents(); //READ
         StudentModel? GetStudentById(int id); //READ

         StudentModel? UpdateStudent (int id, StudentModel updatedStudent); //UPDATE

         bool DeleteStudent(int id); //DELETE
    }
}