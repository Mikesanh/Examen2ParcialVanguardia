using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;
using SolarEnergySystem.Core.Interfaces;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core;

namespace SolarEnergySystem.Infrastructure.Repositories
{
    public class PanelRepository:EntityFrameworkRepository<Panel,string>, IPanelRepository<Panel>    {

        private readonly SolarEnergySystemDatabaseContext context;
        public PanelRepository(SolarEnergySystemDatabaseContext dbContext) 
            : base(dbContext)
        {
            context = dbContext;
        }

        public IEnumerable<Panel> GetPanelsDescendingList()
        {
            return context.Panel.OrderByDescending(x => x.PanelType).ToList();
        }
    }
}
