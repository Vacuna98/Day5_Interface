using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services
{
    public interface IDeviceService
    {
        //What of our project
        

        //Create function for our CRUD

        Device AddDevice(Device newDevice);  //CREATE
        List<Device> GetDevices();  //READ
        Device? GetDeviceById(int id);  //READ
        Device? UpdateDevice(int id, Device updatedDevice);     //UPDATE
        bool DeleteDevice(int id);    //DELETE

        
    }
}