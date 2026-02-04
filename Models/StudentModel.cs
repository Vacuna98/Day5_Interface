using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Services;
using Day5_Interface.Controllers;


namespace Day5_Interface.Models
{
    public class StudentModel
    {
        public int Id { get; set; }
        public string? FullName { get; set; }   
        public string? Email { get; set; }
        public int DeviceCheckedOutId { get; set; }
    }
}