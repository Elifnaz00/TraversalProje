using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Data;
using System.Threading.Tasks;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class CommentController : Controller
    {
        private readonly ICommentService _commentService;

        

        public CommentController(ICommentService commentService, UserManager<AppUser> userManager)
        {
            _commentService = commentService;
            
        }

        [HttpGet]
        public PartialViewResult AddComment()
        {
            return PartialView();
        }
        
        [HttpPost]
        public IActionResult AddComment(Comment c)
        {
            
            c.CommentDate = Convert.ToDateTime(DateTime.Now.ToShortDateString());
            c.CommentState = true; 
            
            _commentService.TAdd(c);
            return RedirectToAction("Index", "Destination");
        }
        
    }
}
