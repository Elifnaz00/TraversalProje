using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface IDestinationDal:IRepository<Destination>
    {
        public Destination GetDestinationWithGuide(int id);

        public List<Destination> GetLast4Destinations();
    }
}
