using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services
{
    private List<StudentModel> students;
    public class StudentService
    {
        students.Add(new StudentModel {StudentName = "Vanessa", School = "CodeStack"});
        students.Add(new StudentModel {StudentName = "Brandon", School = "CodeStack"});
    }

    public bool AddStudent(StudentModel studentToAdd)
    {
        students.Add(studentToAdd);
        return true;
    }

    public List<StudentModel> GetStudents()
    {
        
    }
}