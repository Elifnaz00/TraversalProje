using BusinessLayer.Abstract;
using DataAccesLayer.Abstract;
using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrate
{
    public class SubAboutManager : IGenericServices<SubAbout>
    {
        ISubAboutDal _subaboutdal;

        public SubAboutManager(ISubAboutDal subaboutdal)
        {
            _subaboutdal = subaboutdal;
        }

        public void TAdd(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(SubAbout t)
        {
            throw new NotImplementedException();
        }

        public SubAbout TGetByID(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<SubAbout> TGetList()
        {
            return _subaboutdal.GetList();
        } 

        public void TUpdate(SubAbout t)
        {
            throw new NotImplementedException();
        }
    }
}
