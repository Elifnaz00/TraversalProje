using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json.Linq;

namespace TraversalProje.ViewComponents.Comment
{
    public class _CommentList:ViewComponent
    {
        private readonly ICommentService _commentService;

        public _CommentList(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IViewComponentResult Invoke(int id)
        {
            
            var values= _commentService.TGetListCommentWithDestinationAndUser(id);   
            return View(values); 
            
            
        }
        
    }
}
