using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using PropertyManagementApp.Models;
using System.Diagnostics;

namespace PropertyManagementApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public async Task<IActionResult> IndexAsync()
        {
            //Get RENU Properties
            string url = "https://secure.rently.com/api/properties/searchQuery?managerID=9613";
            string RENUPropertiesJson = "";
            using (HttpClient client = new HttpClient())
            {
                RENUPropertiesJson = await client.GetStringAsync(url);
            }

            RootModel RENUProperties = JsonConvert.DeserializeObject<RootModel>(RENUPropertiesJson);

            return View("Index", RENUProperties);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}