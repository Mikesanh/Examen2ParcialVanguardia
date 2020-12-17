using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SolarEnergySystem.API.Models
{
   public class PanelsDto : BaseEntity<string>
    {

        public string PanelId { get; set; }
        public PanelType PanelType { get; set; }
        public MeasuringUnit MeasuringUnit { get; set; }

      
    }
}
