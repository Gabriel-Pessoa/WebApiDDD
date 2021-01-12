using System.Collections.Generic;
using System.Linq;
using Contacts.Domain.Interfaces;
using Contacts.Domain.Models;
using Contacts.Web.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace Contacts.Web.Controllers
{
    [Route("api/[controller]")]
    public class ContactsController : Controller
    {
        private readonly ContactService _contactService;
        private readonly IRepository<Contact> _contactRepository;

        public ContactsController(ContactService contactService, IRepository<Contact> contactRepository)
        {
            _contactService = contactService;
            _contactRepository = contactRepository;
        }

        [HttpGet]
        public IEnumerable<ContactDTO> GetContacts()
        {
            var contacts = _contactRepository.GetAll();

            var result = contacts.Select(c => new ContactDTO{ Id = c.Id, Name = c.Name, Email = c.Email });

            return result;
        }

        [HttpGet("{id}")]
        public ActionResult<Contact> GetContact(int id)
        {
            var contact = _contactRepository.GetById(id);
            
            if(contact == null)
            {
                return NotFound(new { message = $"Contact id = {id} not fould"});
            }

            return contact;
        }
    }
}