using Microsoft.AspNetCore.Mvc;
using PD.Service.Contact.DomainModels.Contact;
using PD.Service.Contact.Services;
using System.Collections.Generic;
using System.Text.Json;

namespace PD.Service.Contact.Controllers
{
    [Route("api/[controller]")]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        public ContactController(IContactService contactService)
        {
            _contactService = contactService;
        }

        [HttpGet]
        public IEnumerable<ContactQueryDomainModel> List()
        {
            return _contactService.List();
        }

        [HttpGet]
        [Route("{id}")]
        public ContactQueryDomainModel GetContact(int id)
        {
            return _contactService.Get(id);
        }

        [HttpGet("{id}/details")]
        public ContactQueryDomainModel GetContactWithInfo(int id)
        {
            var s=  _contactService.GetWithContactInfo(id);

            return s;

        }

        [HttpPost]
        public void InsertContact([FromBody] object content)
        {
            string contentString = JsonSerializer.Serialize(content);
            var model = JsonSerializer.Deserialize<ContactCreateDomainModel>(contentString);
            _contactService.Insert(model);
        }

        [HttpPut]
        public void UpdateContact([FromBody] object content)
        {
            string contentString = JsonSerializer.Serialize(content);
            var model = JsonSerializer.Deserialize<ContactUpdateDomainModel>(contentString);
            _contactService.Update(model);
        }

        [HttpDelete("{id}")]
        public void DeleteContact(int id)
        {
            _contactService.Delete(id);
        }
    }
}
