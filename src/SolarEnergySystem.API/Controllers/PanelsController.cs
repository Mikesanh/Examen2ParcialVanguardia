using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SolarEnergySystem.Infrastructure;
using SolarEnergySystem.API.Models;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Core.Enums;

namespace SolarEnergySystem.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PanelsController : ControllerBase
    {
        private readonly SolarEnergySystemDatabaseContext _context;
        private readonly IPanelService _panelService;
     

        public PanelsController(SolarEnergySystemDatabaseContext context,IPanelService panelService)
        {
            _context = context;
            _panelService = panelService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_context.Panel.ToList());
        }

        [HttpGet(Name ="GetPanelsList")]
        public ActionResult<IEnumerable<PanelsDto>> GetPanelsDescendingList()
        {
            var ServiceResult = _panelService.GetPanelsDescendingList();
            if (ServiceResult.ResponseCode != ResponseCode.Success)
                return BadRequest(ServiceResult.Error);

            return Ok(ServiceResult.Result.Select(x => new PanelsDto
            {
                PanelId = x.Id,
                PanelType = x.PanelType,
                MeasuringUnit = x.MeasuringUnit
            })) ;
        }
    }
}
