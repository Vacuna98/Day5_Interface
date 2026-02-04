using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services;

   
    public class StudentService : IStudentService
    {
        //CREATE a list of student
        private readonly List<StudentModel> _studentList = new();

        //Constructor
        public StudentService()
    {
        _studentList.Add(new StudentModel {
            Id = 1, 
            FullName = "Vanessa Acuna", 
            Email = "vacuna@gmail.com",
            DeviceCheckedOutId = null
            });


            _studentList.Add(new StudentModel {
            Id = 2, 
            FullName = "Darcy Rose", 
            Email = "darsy@gmail.com",
            DeviceCheckedOutId = 2
            });
    }


    //----------------Create a student--------------------
    public StudentModel AddStudent (StudentModel newStudent)
    {
        int newId = _studentList.Count == 0 ? 1 : _studentList.Max(s => s.Id) + 1;
            newStudent.Id = newId;
            _studentList.Add(newStudent);
            return newStudent;
    }

//---------------- Delete --------------------
    public bool DeleteStudent(int id)
    {
        StudentModel? student = _studentList.FirstOrDefault(s => s.Id == id);
        if (student == null)
        {
            return false;
        }

        _studentList.Remove(student);
        return true;
    }



    //---------------Read-------------------------


    

    public StudentModel? GetStudentById(int id)
    {
       return _studentList.FirstOrDefault(s => s.Id ==id);
    }



    //------------------- Read -----------------------

    public List<StudentModel> GetStudents()
    {
        return _studentList;
    }

    //------------------- Update -----------------------
     public StudentModel? UpdateStudent(int id, StudentModel updatedStudent)
        {
            StudentModel? existingStudent = _studentList.FirstOrDefault(s => s.Id == id);

            if(existingStudent == null)
            {
                return null;
            }
            existingStudent.FullName = updatedStudent.FullName;
            existingStudent.Email = updatedStudent.Email;
            existingStudent.DeviceCheckedOutId = updatedStudent.DeviceCheckedOutId;
           

            return existingStudent;
        }

    }
