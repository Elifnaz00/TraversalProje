using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IContactUsDal:IRepository<ContactUs>
    {
        public List<ContactUs> GetListContactUsTrue();
        public List<ContactUs> GetListContactUsFalse();
        public void  ContactUsStatusChangeToFalse(int id);

    }
}
