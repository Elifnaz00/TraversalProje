using DataAccesLayer.Abstract;
using DataAccesLayer.Concrete;
using DataAccesLayer.Repository;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.EntityFramework
{
    public class EfContactUsDal : Repository<ContactUs>, IContactUsDal
    {
        private readonly Context _context;

        public EfContactUsDal(Context context)
        {
            _context = context;
        }

        public void ContactUsStatusChangeToFalse(int id)
        {
            var values= _context.ContactUses.Select(x => x.ContactUsID == id);
           

        }

        public List<ContactUs> GetListContactUsFalse()
        {
           
                var values= _context.ContactUses.Where(x=> x.MessageStatus == false).ToList();
                return values;
           
        }

        public List<ContactUs> GetListContactUsTrue()
        {
                var values = _context.ContactUses.Where(x => x.MessageStatus == true).ToList();
                return values;
           
        }
    }
}
