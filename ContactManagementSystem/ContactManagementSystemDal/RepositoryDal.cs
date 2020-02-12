using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactManagementSystemModel;

namespace ContactManagementSystemDal
{
    public class RepositoryDal : IRepositoryDal
    {
        private static List<Contact> contacts;
        public RepositoryDal()
        {
            contacts = new List<Contact>()
            {
                new Contact { Id = 1, FirstName = "Mangesh" , LastName ="Dusane", Email = "dusaneml@gmail.com",PhoneNumber ="7896541230", Status =true}
            };
        }

        public bool DeleteContact(int id)
        {
            bool isDeleted = false;
            Contact existingContact = contacts.Find(x => x.Id == id && x.Status == true);
            if (existingContact != null)
            {
                existingContact.Status = false;
                isDeleted = true;
            }
            return isDeleted;
        }

        public List<Contact> GetContactList()
        {
            return contacts;
        }

        public Contact InsertContact(Contact contact)
        {
            contact.Id = contacts.Max(x => x.Id) + 1;
            contacts.Add(contact);
            return contact;
        }

        public bool UpdateContact(int id, Contact contact)
        {
            bool isUpdated = false;
            Contact existingContact = contacts.Find(x => x.Id == id);
            if (existingContact != null)
            {
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                existingContact.Email = contact.Email;
                existingContact.FirstName = contact.FirstName;
                existingContact.LastName = contact.LastName;
                isUpdated = true;
            }
            return isUpdated;
        }
    }
}
