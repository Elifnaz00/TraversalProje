using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IReservationDal:IRepository<Reservation>
    {
        
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        List<Reservation> GetListWithReservationByAccept(int id);
        List<Reservation> GetListWithReservationByPrevious(int id);
        
    }
}
