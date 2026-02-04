using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;
using Day5_Interface.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Day5_Interface.Controllers
{
    [Route("[controller]")]
    public class DeviceController : ControllerBase
    {
        private readonly IDeviceService _deviceService;

        public DeviceController(IDeviceService deviceService)
        {
            _deviceService = deviceService;
            
        }

        //Read All
        [HttpGet("getDeviceList")]

        public List<Device> GetDevices()
        {
         return _deviceService.GetDevices();
            
        }

        //Real Id
        [HttpGet("GetAddDeviceById/{id}")]
        public Device? GetDeviceById(int id)
        {
            return _deviceService.GetDeviceById(id);
        }

        //Create
        [HttpPost("AddDevice")]
        public Device AddDevice(Device device)
        {
            return _deviceService.AddDevice(device);
        }

        //Update
        [HttpPut("updateDevice/{id}")]

        public Device? UpdateDevice(int id, Device device)
        {
            return _deviceService.UpdateDevice(id, device);
        }

        //Delete
        [HttpDelete("removeDevice/{id}")]
        public bool DeleteDevice(int id)
        {
            return _deviceService.DeleteDevice(id);
        }




    }
}