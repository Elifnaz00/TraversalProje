using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IReservationService:IGenericServices<Reservation>
    {
        
        List<Reservation> GetListWithReservationByWaitAprroval(int id);
        public List<Reservation> GetListWithReservationByPrevious(int id);

        public List<Reservation> GetListWithReservationByAccept(int id);
        
    }
}
