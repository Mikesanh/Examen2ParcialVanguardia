﻿using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Core.Enums;
using System.Linq;

namespace SolarEnergySystem.Core.Services
{
    public class ElectricityReadingService : IElectricityReadingService
    {
        private readonly IElectricityReadingService _electricityReadingService;
         

        public ElectricityReadingService(IElectricityReadingService electricityReadingService)
        {
            _electricityReadingService = electricityReadingService;
        }
        public ServiceResult<ElectricityReading> AddElectricityReading(ElectricityReading ER)
        {
            ER.ReadingDateTime = DateTime.UtcNow;
            if (ER.KiloWatt < 0)
            {
                return ServiceResult<ElectricityReading>.ErrorResult("No se aceptan vlaores menores a 0")
            }; 
            if (ER.Panel.MeasuringUnit.Equals("Watt"))
            {
                ER.KiloWatt = ER.KiloWatt / 1000;
            };
            //if (ER.Panel.PanelType ==    ) 
            //{ }

            return ServiceResult<ElectricityReading>.SuccessResult(_electricityReadingService.AddElectricityReading(ER));
        }
    }
}
