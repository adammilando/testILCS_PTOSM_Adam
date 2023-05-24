using Microsoft.AspNetCore.Mvc;
using MonitoringTruck.Models;
using MonitoringTruck.Services;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MonitoringTruck.Controllers
{
    public class TruckMonitoringController : Controller
    {
        private readonly TruckMonitoringService _truckService;

        public TruckMonitoringController(TruckMonitoringService truckService)
        {
            _truckService = truckService;
        }

        public async Task<IActionResult> Index()
        {
            Root result = await _truckService.GetTruckData();
            //List<Datum> filteredData = result.result.data.ToList();

            return View(result);
        }
    }


}
