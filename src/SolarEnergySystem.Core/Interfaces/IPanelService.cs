using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;

namespace SolarEnergySystem.Core.Interfaces
{
    public interface IPanelService
    {
        ServiceResult<IEnumerable<Panel>> GetPanelsDescendingList();
    }
}
