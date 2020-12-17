using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;

namespace SolarEnergySystem.Infrastructure.Repositories

{
    class ElectricityReadingRepository : EntityFrameworkRepository<ElectricityReading, int>, IElectricityReadingRepository
    {
        private readonly SolarEnergySystemDatabaseContext context;
        public ElectricityReadingRepository(SolarEnergySystemDatabaseContext dbContext)
       : base(dbContext)
        {
            context = dbContext;
        }


        public ElectricityReading AddElectricityReading(ElectricityReading ER)
        {
            context.ElectricityReading.Add(ER);
            context.SaveChanges();
            return ER;
        }

        public ElectricityReading LowestTimeReading(string pId)
        {
            
                
        }

        
    }
}
