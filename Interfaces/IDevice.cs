using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;

namespace DeviceManagement_WebApp.Interfaces
{
    public interface IDevice
    {
        IEnumerable<Device> GetDevices();
        Device GetDeviceId(int DeviceId);
        Device GetDeviceName(string DeviceName);
        Device GetDeviceDescription(string DeviceDescription);
        void InsertDevice(Device device_);
        void UpdateDevice(Device device_);
        void DeleteDevice(int DeviceId);
        void SaveChanges();
    }
}
