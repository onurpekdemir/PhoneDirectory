using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace PD.Api.Gateway.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IConfiguration _configuration;
        private readonly string _contactServiceUrl, _reportServiceUrl;

        public ContactController(IConfiguration configuration)
        {
            _configuration = configuration;
            _contactServiceUrl = _configuration["ServiceSettings:ContactServiceUrl"].ToString();
            _reportServiceUrl = _configuration["ServiceSettings:ReportServiceUrl"].ToString();
        }

 
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_contactServiceUrl);
                var result = await client.GetAsync("api/contact");
                string resultContentString = await result.Content.ReadAsStringAsync();
                result.EnsureSuccessStatusCode();
                return Ok(resultContentString);
            }
        }

        // GET api/<HomeController>/5
        [HttpGet("{id}")]
        public async Task<IActionResult> Get(int id)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(_contactServiceUrl);
                var result = await client.GetAsync($"api/contact/{id}/details");
                string resultContentString = await result.Content.ReadAsStringAsync();
                result.EnsureSuccessStatusCode();
                return Ok(resultContentString);
            }
        }

        // POST api/<HomeController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        
        public async Task<IActionResult> Put([FromBody] object content)
        {
           var contentString =  JsonSerializer.Serialize(content);
            return null;
        }

        // DELETE api/<HomeController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
