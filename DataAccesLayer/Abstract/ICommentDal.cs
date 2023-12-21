using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccesLayer.Abstract
{
    public interface ICommentDal:IRepository<Comment> 
    {
        public List<Comment> GetListCommentWithDestination();

        public List<Comment> GetListCommentWithDestinationAndUser(int id);
            
    }
    
}
