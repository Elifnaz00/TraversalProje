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
    public class EfGuideDal : Repository<Guide>, IGuideDal
    {
        Context context = new Context();
        public void ChangeToFalseByGuide(int id)
        {
            
            var values =context.Guides.Find(id);
            values.Status = false;
            context.SaveChanges();
        }

        public void ChangeToTrueByGuide(int id)
        {
            var values= context.Guides.Find(id);
            values.Status = true;
            context.SaveChanges();
        }
    }
}
