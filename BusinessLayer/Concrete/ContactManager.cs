using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ContactManager : IContactService
    {
        IContactDal _contactDal;

        public ContactManager(IContactDal contactDal)
        {
            _contactDal = contactDal;
        }

        public void AddContact(Contact contact)
        {
            _contactDal.Insert(contact);
        }

        public void DeleteContact(int id)
        {
            _contactDal.Delete(GetByID(id));
        }

        public void DeleteContact(Contact contact)
        {
            _contactDal.Delete(contact);
        }

        public Contact GetByID(int id)
        {
            return _contactDal.get(x =>x.ContactID == id);
        }

        public List<Contact> GetList()
        {
            return _contactDal.List();
        }

        public void UpdateContact(Contact contact)
        {
            _contactDal.Update(contact);
        }
    }   
}
