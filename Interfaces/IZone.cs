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
    public interface IZone
    {
        IEnumerable<Zone> GetZones();
        Zone GetZoneId(int ZoneId);
        Zone GetZoneName(string ZoneName);
        Zone GetZoneDescription(string ZoneDescription);
        void InsertZone(Zone zone_);
        void UpdateZone(Zone zone_);
        void DeleteZone(int ZoneId);
        void SaveChanges();
    }
}
