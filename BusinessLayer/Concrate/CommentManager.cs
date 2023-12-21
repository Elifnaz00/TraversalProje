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
    
    public class CommentManager : ICommentService
    {
        ICommentDal _commentdal;

        public CommentManager(ICommentDal commentdal)
        {
            _commentdal = commentdal;
        }

        public void TAdd(Comment t)
        {
            _commentdal.Insert(t);
        }

        public void TDelete(Comment t)
        {
            _commentdal.Delete(t);
        }

        public Comment TGetByID(int id)
        {
            return _commentdal.GetByID(id);    
        }
        
        public List<Comment> TGetList()
        {
            return _commentdal.GetList();
        } 
        public List<Comment> TGetDestinationById(int id) 
        {
            return _commentdal.GetListByFilter(x => x.DestinationID == id);
           
        } 

        public void TUpdate(Comment t)
        {
            throw new NotImplementedException();
        }

        public List<Comment> TDestinationById(int id)
        {
            return _commentdal.GetListByFilter(x=> x.DestinationID == id);  
        }

        public List<Comment> TGetListCommentWithDestination()
        {
            return _commentdal.GetListCommentWithDestination();
        }

        public List<Comment> TGetListCommentWithDestinationAndUser(int id)
        {
            return _commentdal.GetListCommentWithDestinationAndUser(id);
        }
    }
    


}
