using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.EntityFrameworkCore.Diagnostics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class AboutManager// : IAboutService
    {
        IAboutDal _aboutdal;

        public AboutManager (IAboutDal aboutrepo)
        {
            _aboutdal = aboutrepo;
        }

        public void TAdd(About t)
        {
            _aboutdal.Insert(t);
        }

        public void TDelete(About t)
        {
            _aboutdal.Delete(t);
        }

        public About TGetByID(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<About> TGetList()
        {
            return _aboutdal.GetList();
        } 

        public void TUpdate(About t)
        {
            _aboutdal.Update(t);
        }
    }
}
