using System;
using System.Collections.Generic;
using System.Text;
using BlogApp.Business.Abstract;

namespace BlogApp.Business.Concrete
{
    public class ChartManager : IChartService
    {

        private readonly IBackendService _backendService;
        private readonly IFrontendService _frontendService;
        private readonly IDatabaseService _databaseService;
        private readonly IDevopsService _devopsService;

        public ChartManager(IBackendService backendService, IFrontendService frontendService, IDatabaseService databaseService, IDevopsService devopsService)
        {
            _backendService = backendService;
            _frontendService = frontendService;
            _databaseService = databaseService;
            _devopsService = devopsService;
        }


        public ChartModel getChartModel()
        {
            ChartModel chart = new ChartModel();
            chart.BackendSize = _backendService.GetList().Count;
            chart.FrontendSize = _frontendService.GetList().Count;
            chart.DatabaseSize = _databaseService.GetList().Count;
            chart.DevopsSize = _devopsService.GetList().Count;

            return chart;
        }





    }
}
