using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Day5_Interface.Models
{
    public class Device
    {
        
            //Id Int
            public int Id { get; set; }
            //Name string
            public string? Name { get; set; }
            //Type string
            public string? Type { get; set; }
            // Serial Number string
            public string? SerialNumber { get; set; }
            //IsCheckedOut bool
            public bool IsCheckedOut { get; set; }
        

    }
}