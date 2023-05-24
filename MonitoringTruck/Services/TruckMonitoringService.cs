using Microsoft.Extensions.Configuration;
using MonitoringTruck.Models;
using System.Net.Http;
using System.Net.Http.Json;
using System.Text.Json;
using System.Threading.Tasks;

namespace MonitoringTruck.Services
{
    public class TruckMonitoringService
    {
        private readonly HttpClient _httpClient;
        private readonly IConfiguration _configuration;

        public TruckMonitoringService(HttpClient httpClient, IConfiguration configuration)
        {
            _httpClient = httpClient;
            _configuration = configuration;
        }

        public async Task<Root> GetTruckData()
        {
            string baseUrl = _configuration["TruckApi:BaseUrl"];
            string offset = _configuration["TruckApi:Offset"];
            string limit = _configuration["TruckApi:Limit"];
            string cari = _configuration["TruckApi:Cari"];
            string token = _configuration["TruckApi:Token"];

            string url = $"{baseUrl}?offset={offset}&limit={limit}&cari={cari}&token={token}";

            var result = await _httpClient.GetFromJsonAsync<Root>(url);
            return result;
        }
    }


}
