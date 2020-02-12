using ContactManagementSystemBl;
using ContactManagementSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace ContactManagementSystem.Controllers
{
    public class ContactController : ApiController
    {
        private IContactBl _contactBl;

        public ContactController(IContactBl contactBl)
        {
            _contactBl = contactBl;
        }
        /// <summary>
        /// Returns List of Contact 
        /// </summary>
        /// <returns>List of ContactResponse</returns>
        // GET: api/Contact
        public IEnumerable<ContactResponse> Get()
        {
            return _contactBl.GetContactList();
        }
        /// <summary>
        /// Insert new contact
        /// </summary>
        /// <param name="contact">New Contact Request</param>
        /// <returns>Returns newly inserted contact</returns>
        // POST: api/Contact
        public ContactResponse Post([FromBody]ContactRequest contact)
        {
            return _contactBl.InsertContact(contact);
        }
        /// <summary>
        /// Updated existing contact
        /// </summary>
        /// <param name="id">existing contact id </param>
        /// <param name="contact">Updated Contact Request</param>
        /// <returns>Returns true if contact successfully updated</returns>
        // PUT: api/Contact/5
        public bool Put(int id, [FromBody]ContactRequest contact)
        {
            return _contactBl.UpdateContact(id, contact);
        }
        /// <summary>
        /// Delete existing contact
        /// </summary>
        /// <param name="id">Contact id</param>
        /// <returns>Returns true if contact successfully deleted</returns>
        // DELETE: api/Contact/5
        public bool Delete(int id)
        {
            return _contactBl.DeleteContact(id);
        }
    }
}
