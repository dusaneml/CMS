using ContactManagementSystemModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagementSystemBl
{
    public interface IContactBl
    {
        List<ContactResponse> GetContactList();
        ContactResponse  InsertContact(ContactRequest contact);

        bool UpdateContact(int id, ContactRequest contact);

        bool DeleteContact(int id);
    }
}
