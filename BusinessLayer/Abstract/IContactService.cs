using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    internal interface IContactService
    {
        List<Contact> GetList();
        void AddContact(Contact contact);
        Contact GetByID(int id);
        void DeleteContact(int id);
        void DeleteContact(Contact contact);
        void UpdateContact(Contact contact);
    }
}
