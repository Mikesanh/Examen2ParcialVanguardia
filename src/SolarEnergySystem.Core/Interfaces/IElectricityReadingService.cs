using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;

namespace SolarEnergySystem.Core.Interfaces
{
    public interface IElectricityReadingService 
    {

        ServiceResult<ElectricityReading> AddElectricityReading(ElectricityReading ER);
        //ServiceResult<ElectricityReading> LowestTimeReading(string pId);


    }
}
