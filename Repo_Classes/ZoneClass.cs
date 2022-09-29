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
    public class ZoneClass
    {
        private ConnectedOfficeContext _zoneRepository;
        public ZoneClass(ConnectedOfficeContext datacontext)
        {
            this._zoneRepository = datacontext;
        }

        public void DeleteCategory(int ZoneId)
        {
            Zone zone = _zoneRepository.Zone.Find(ZoneId);
            _zoneRepository.Zone.Remove(zone);
        }
        public Zone GetZoneId(int ZoneId)
        {
            return _zoneRepository.Zone.Find(ZoneId);
        }

        public Zone GetZoneName(string ZoneName)
        {
            return _zoneRepository.Zone.Find(ZoneName);

        }

        public Zone GetZoneDescription(string ZoneDescription)
        {
            return _zoneRepository.Zone.Find(ZoneDescription);
        }

        public IEnumerable<Zone> GetZones()
        {
            return _zoneRepository.Zone.ToList();
        }

        public void InsertZone(Zone zone)
        {
            _zoneRepository.Zone.Add(zone);
        }

        public void SaveChanges()
        {
            _zoneRepository.SaveChanges();
        }

        public void UpdateZone(Zone zone)
        {
            _zoneRepository.Entry(zone).State = EntityState.Modified;
        }
    }
}
