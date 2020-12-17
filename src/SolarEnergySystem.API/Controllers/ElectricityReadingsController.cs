using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarEnergySystem.Infrastructure;
using SolarEnergySystem.API.Models;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Core.Enums;
using SolarEnergySystem.Core.Entities;

namespace SolarEnergySystem.API.Controllers
{
    public class ElectricityReadingsController : Controller
    {

        private readonly IElectricityReadingService _electricityReadingService;

        public ElectricityReadingsController(IElectricityReadingService electricityReadingService)
        {
            _electricityReadingService = electricityReadingService;
        }
        // GET: ElectricityReadingsController
        public ActionResult Index()
        {
            return View();
        }

        // GET: ElectricityReadingsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ElectricityReadingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ElectricityReadingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Post([FromBody] ElectricityReading bodyER)
        {
            var serviceResult = _electricityReadingService.AddElectricityReading(bodyER);        
                if (serviceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(serviceResult.Error);
            var result = new ElectricityReading
            {
                Id = serviceResult.Result.Id,
                KiloWatt = serviceResult.Result.KiloWatt,
                Panel = serviceResult.Result.Panel,
                PanelId = serviceResult.Result.PanelId,
                ReadingDateTime = serviceResult.Result.ReadingDateTime
               
            };
            
            return Ok(result);
        }

        // GET: ElectricityReadingsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ElectricityReadingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ElectricityReadingsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ElectricityReadingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
