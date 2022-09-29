using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using DeviceManagement_WebApp.Data;
using DeviceManagement_WebApp.Models;
using DeviceManagement_WebApp.Interfaces;
using DeviceManagement_WebApp.Controllers;
using System.Web;
using System.Data;


namespace DeviceManagement_WebApp
{
    public class DeviceClass : IDevice
    {
        private ConnectedOfficeContext _deviceRepository;
        public DeviceClass(ConnectedOfficeContext datacontext)
        {
            this._deviceRepository = datacontext;
        }

        public void DeleteDevice(int DeviceId)
        {
            Device device = _deviceRepository.Device.Find(DeviceId);
            _deviceRepository.Device.Remove(device);
        }
        public Device GetDeviceId(int DeviceId)
        {
            return _deviceRepository.Device.Find(DeviceId);
        }

        public Device GetDeviceName(string DeviceName)
        {
            return _deviceRepository.Device.Find(DeviceName);

        }

        public Device GetDeviceDescription(string DeviceDescription)
        {
            return _deviceRepository.Device.Find(DeviceDescription);
        }

        public IEnumerable<Device> GetDevices()
        {
            return _deviceRepository.Device.ToList();
        }

        public void InsertDevice(Device device)
        {
            _deviceRepository.Device.Add(device);
        }

        public void SaveChanges()
        {
            _deviceRepository.SaveChanges();
        }

        public void UpdateDevice(Device device)
        {
            _deviceRepository.Entry(device).State = EntityState.Modified;
        }
    }
}
