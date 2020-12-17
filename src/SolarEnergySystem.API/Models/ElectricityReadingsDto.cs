using System;
using System.Collections.Generic;
using System.Linq;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Enums;
using System.Threading.Tasks;

namespace SolarEnergySystem.API.Models
{
    public class ElectricityReadingsDto: BaseEntity<int>
    {
        public string PanelId { get; set; }

        public Panel Panel { get; set; }

        public double KiloWatt { get; set; }

        public DateTime ReadingDateTime { get; set; }
    }
}
