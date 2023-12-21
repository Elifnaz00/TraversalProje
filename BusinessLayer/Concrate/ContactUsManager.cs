using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class ContactUsManager : IContactUsService
    {
        private readonly IContactUsDal _contactusdal;
        

        public ContactUsManager(IContactUsDal contactusdal)
        {
            _contactusdal = contactusdal;
        }

        public void TAdd(ContactUs t)
        {
            _contactusdal.Insert(t);
        }

        public void TContactUsStatusChangeToFalse(int id)
        {
            _contactusdal.ContactUsStatusChangeToFalse(id);
        }

        public void TDelete(ContactUs t)
        {
            _contactusdal.Delete(t);
        }

        public ContactUs TGetByID(int id)
        {
            return _contactusdal.GetByID(id);
        }

        public List<ContactUs> TGetList()
        {
            return _contactusdal.GetList();
        }

        public List<ContactUs> TGetListContactUsFalse()
        {
            return _contactusdal.GetListContactUsFalse();
        }

        public List<ContactUs> TGetListContactUsTrue()
        {
            return _contactusdal.GetListContactUsTrue();
        }

        public void TUpdate(ContactUs t)
        {
            _contactusdal.Update(t);
        }
    }
}
