using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;

namespace SolarEnergySystem.Core.Interfaces
{
  public interface IElectricityReadingRepository
    {
        ElectricityReading AddElectricityReading(ElectricityReading ER);
        ElectricityReading LowestTimeReading(string pId);


    }
}
