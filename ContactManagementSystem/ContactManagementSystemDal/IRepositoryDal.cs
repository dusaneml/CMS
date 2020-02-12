using ContactManagementSystemModel;
using System;
using System.Collections.Generic;
using System.Text;

namespace ContactManagementSystemDal
{
    public interface IRepositoryDal
    {
        List<Contact> GetContactList();
        Contact  InsertContact(Contact contact);

        bool UpdateContact(int id, Contact contact);

        bool DeleteContact(int id);
    }
}
