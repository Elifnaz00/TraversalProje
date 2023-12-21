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
    public class TestimonialManager  : IGenericServices<Testimonial>
    {
        ITestimonialDal _testimonialDal;

        public TestimonialManager (ITestimonialDal testimonial)
        {
            _testimonialDal = testimonial;

        }
        public void TAdd(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public void TDelete(Testimonial t)
        {
            throw new NotImplementedException();
        }

        public Testimonial TGetByID(int id)
        {
            throw new NotImplementedException();
        }
        
        public List<Testimonial> TGetList()
        {
            return _testimonialDal.GetList();   
        } 

        public void TUpdate(Testimonial t)
        {
            throw new NotImplementedException();
        }
    }

}
