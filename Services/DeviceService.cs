using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Day5_Interface.Models;

namespace Day5_Interface.Services
{
    public class DeviceService : IDeviceService
    {
        //CREATE A LIST OF DEVICES
        private readonly List<Device> _deviceList = new();

        //CONSTRUCTOR (short cut is "ctor")
        public DeviceService()
        {
    //-------------------------------- OUR SERVICE IS OUR "HOW" ---------------------------------
            _deviceList.Add(new Device
            {
                Id = 1, 
                Name = "Dell",
                Type = "Laptop",
                SerialNumber = "SN-1234",
                IsCheckedOut = true
            });

            _deviceList.Add(new Device
            {
                Id = 2, 
                Name = "Ipad",
                Type = "Tablet",
                SerialNumber = "SN-5678",
                IsCheckedOut = false
            });

            _deviceList.Add(new Device
            {
                Id = 1, 
                Name = "Dell",
                Type = "Laptop",
                SerialNumber = "SN-1234",
                IsCheckedOut = true
            });
        }


//-------------------- CREATE a device ----------------------------------
        public Device AddDevice(Device newDevice)
        {
            int newId = _deviceList.Count == 0 ? 1 : _deviceList.Max(d => d.Id) + 1;
            newDevice.Id = newId;
            _deviceList.Add(newDevice);
            return newDevice;
        }

//------------------- DELETE a device -------------------------------------
        public bool DeleteDevice(int id)
        {
            Device? device =_deviceList.FirstOrDefault(d => d.Id == id);
            if(device == null)
            {
                return false;
            }
            _deviceList.Remove(device);
            return true;
        }

//-------------------- READ -----------------------------------------------
        public Device? GetDeviceById(int id)
        {
            return _deviceList.FirstOrDefault(d => d.Id ==id);
        }
//-------------------- READ ------------------------------------------------
        public List<Device> GetDevices()
        {
            return _deviceList;
        }

//------------------- UPDATE -----------------------------------------------
        public Device? UpdateDevice(int id, Device updatedDevice)
        {
            Device? existingDevice = _deviceList.FirstOrDefault(d => d.Id == id);

            if(existingDevice == null)
            {
                return null;
            }
            existingDevice.Name = updatedDevice.Name;
            existingDevice.Type = updatedDevice.Type;
            existingDevice.SerialNumber = updatedDevice.SerialNumber;
            existingDevice.IsCheckedOut = updatedDevice.IsCheckedOut;

            return existingDevice;
        }
    }
}