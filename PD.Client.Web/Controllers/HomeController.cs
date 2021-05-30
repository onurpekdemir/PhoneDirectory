using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PD.Client.Web.Models;
using PD.Client.Web.Utils;

namespace PD.Client.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestfulApiClient _apiClient;

        public HomeController(IRestfulApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IActionResult> Index()
        {

         

          //  var s = await _apiClient.Get<string>("api/contact");
            return View();
        }

        public IActionResult Report()
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
