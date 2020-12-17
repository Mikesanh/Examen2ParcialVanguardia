using System;
using System.Collections.Generic;
using System.Text;
using SolarEnergySystem.Core.Entities;
using SolarEnergySystem.Core.Interfaces;
using System.Linq;
namespace SolarEnergySystem.Core.Services
{
    public class PanelService : IPanelService
    {
        private readonly IPanelRepository<Panel> _panelRepository;



        public PanelService(IPanelRepository<Panel> panelRepository)
        {
            _panelRepository = panelRepository;    
        }

        public ServiceResult<IEnumerable<Panel>> GetPanelsDescendingList()
        {
            return ServiceResult<IEnumerable<Panel>>.SuccessResult(_panelRepository.GetPanelsDescendingList());
        }
    }
}
