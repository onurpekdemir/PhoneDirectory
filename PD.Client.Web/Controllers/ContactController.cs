using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PD.Client.Web.Models;
using PD.Client.Web.Utils;

namespace PD.Client.Web.Controllers
{
    public class ContactController : Controller
    {
        private readonly IRestfulApiClient _apiClient;
        public ContactController(IRestfulApiClient apiClient)
        {
            _apiClient = apiClient;
        }

        public async Task<IActionResult> Index()
        {
            var contacts = await _apiClient.Get<List<ContactQueryViewModel>>("api/contact");
            return View(contacts);
        }


        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> Add(ContactCreateViewModel model)
        {
            await _apiClient.Post<ContactCreateViewModel>("api/contact", model);
            return View();
        }

        public async Task<IActionResult> Update(int id)
        {
            var contact = await _apiClient.Get<ContactUpdateViewModel>($"api/contact/{id}");
            return View(contact);
        }

        [HttpPost]
        public async Task<IActionResult> Update(ContactUpdateViewModel model)
        {
            await _apiClient.Put<ContactUpdateViewModel>("api/contact", model);
            return View();
        }

        public async Task<IActionResult> Delete(int id)
        {
            await _apiClient.Delete($"api/contact/{id}");
            return View();
        }

        public async Task<IActionResult> Details(int id)
        {
            var contacts = await _apiClient.Get<ContactQueryWithInfoViewModel>($"api/contact/{id}");
            return View(contacts);
        }
    }
}
