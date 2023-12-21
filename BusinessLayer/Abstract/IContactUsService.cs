using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IContactUsService:IGenericServices<ContactUs>
    {
        public List<ContactUs> TGetListContactUsTrue();
        public List<ContactUs> TGetListContactUsFalse();
        public void TContactUsStatusChangeToFalse(int id);
       
    }
}
