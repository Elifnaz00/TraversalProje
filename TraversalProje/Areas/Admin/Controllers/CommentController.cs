using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TraversalProje.Areas.Admin.Models;
using TraversalProje.ViewComponents.Comment;

namespace TraversalProje.Areas.Admin.Controllers
{
    
    [Area("Admin")]
    [Route("Admin/[controller]/[action]")]
    [Authorize(Roles = "Admin")]


    public class CommentController : Controller
    {
        public readonly ICommentService _commentService;

        public CommentController(ICommentService commentService)
        {
            _commentService = commentService;
        }

        public IActionResult Index()
        {
          
            var commentlist= _commentService.TGetListCommentWithDestination();
            return View(commentlist); 

        }

        public IActionResult DeleteComment(int id) 
        {
            var values= _commentService.TGetByID(id);
            _commentService.TDelete(values);
            return RedirectToAction("Index", "Comment", new { Area = "Admin" });
        }
    }
}
