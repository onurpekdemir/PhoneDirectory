using Microsoft.AspNetCore.Mvc;
using PD.Service.Contact.DomainModels.Contact;
using PD.Service.Contact.Services;
using System.Collections.Generic;

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

        [HttpGet("{id}")]
        public ContactQueryDomainModel GetContact(int id)
        {
            return _contactService.Get(id);
        }

        [HttpPost]
        public void InsertContact([FromBody] ContactCreateDomainModel model)
        {
            _contactService.Insert(model);
        }

        [HttpPut]
        public void UpdateContact([FromBody] ContactUpdateDomainModel model)
        {
            _contactService.Update(model);
        }

        [HttpDelete("{id}")]
        public void DeleteContact(int id)
        {
            _contactService.Delete(id);
        }
    }
}
