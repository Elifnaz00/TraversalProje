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
    public class ReservationManager : IReservationService
    {
        IReservationDal _reservationdal;

        public ReservationManager(IReservationDal reservationdal)
        {
            _reservationdal = reservationdal;
        }
        
        public List<Reservation> GetListWithReservationByAccept(int id)
        {
            return _reservationdal.GetListWithReservationByAccept(id);
            
        } 

        public List<Reservation> GetListWithReservationByPrevious(int id)
        {
            return _reservationdal.GetListWithReservationByPrevious(id);
           

        }
        
        public List<Reservation> GetListWithReservationByWaitAprroval(int id)
        {
            return _reservationdal.GetListWithReservationByWaitAprroval(id);
           
        } 

        public void TAdd(Reservation t)
        {
            _reservationdal.Insert(t);
        }

        public void TDelete(Reservation t)
        {
            throw new NotImplementedException();
        }

        public Reservation TGetByID(int id)
        {
            throw new NotImplementedException();
        }

        public List<Reservation> TGetList()
        {
            throw new NotImplementedException();
        }

        public void TUpdate(Reservation t)
        {
            throw new NotImplementedException();
        }
        
    }
}
