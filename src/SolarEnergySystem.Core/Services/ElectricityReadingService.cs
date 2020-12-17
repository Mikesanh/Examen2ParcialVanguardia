using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
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
            if (ER.KiloWatt < 0)
            {
                return ServiceResult<ElectricityReading>.ErrorResult("No se aceptan vlaores menores a 0")
            }
            //if (ER.Panel.MeasuringUnit.Equals("Watt"))
            //{
            //   ER.
            //}

             return ServiceResult<ElectricityReading>.SuccessResult(_electricityReadingService.AddElectricityReading(ER));
        }
    }
}
