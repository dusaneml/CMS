using ContactManagementSystemDal;
using ContactManagementSystemModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ContactManagementSystemBl
{
    public class ContactBl : IContactBl
    {
        private IRepositoryDal _repositoryDal;

        public ContactBl(IRepositoryDal repositoryDal)
        {
            this._repositoryDal = repositoryDal;
        }

        public bool DeleteContact(int id)
        {
            return this._repositoryDal.DeleteContact(id);
        }

        public List<ContactResponse> GetContactList()
        {
            return MapToConatctResponseList( this._repositoryDal.GetContactList());
        }

        public ContactResponse InsertContact(ContactRequest contactRequest)
        {
            return MapToConatctResponse(this._repositoryDal.InsertContact(this.MapToConatct(contactRequest)));
        }

        public bool UpdateContact(int id,ContactRequest contactRequest)
        {
            return this._repositoryDal.UpdateContact(id, this.MapToConatct(contactRequest));
        }

        private Contact MapToConatct(ContactRequest contactRequest)
        {
            return new Contact() { 
                FirstName = contactRequest.FirstName,
                LastName = contactRequest.LastName,
                PhoneNumber = contactRequest.PhoneNumber,
                Email = contactRequest.Email,
                Status = true
            };
        }

        private ContactResponse MapToConatctResponse(Contact contact)
        {
            return new ContactResponse()
            {
                Id = contact.Id, 
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                PhoneNumber = contact.PhoneNumber,
                Email = contact.Email,
                Status = contact.Status ? "Active" : "In active"
            };
        }

        private List<ContactResponse> MapToConatctResponseList(List<Contact> contacts)
        {
            return contacts.Select(contact => new ContactResponse()
            {
                Id = contact.Id,
                FirstName = contact.FirstName,
                LastName = contact.LastName,
                PhoneNumber = contact.PhoneNumber,
                Email = contact.Email,
                Status = contact.Status ? "Active" : "In active"
            }).ToList<ContactResponse>();            
        }
    }
}
