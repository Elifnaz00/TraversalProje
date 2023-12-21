using AutoMapper;
using BusinessLayer.Abstract;
using BusinessLayer.Concrate;
using DataAccesLayer.EntityFramework;
using DTOLayer.DTOs.ContactDTOs;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class ContactController : Controller
    {
        private readonly IContactUsService _contactUsService;
        private readonly IMapper _mapper;
        public ContactController(IContactUsService contactService, IMapper mapper)
        {
            _contactUsService = contactService;
            _mapper = mapper;
        }

       
        public IActionResult Index()
        {
            return View();
        }

        
        public PartialViewResult Breadcrumb()
        {
            return PartialView();
        }
        public PartialViewResult ContactFrom()
        {
            return PartialView();
        }

        [HttpGet]
        public PartialViewResult SendMessage()
        {
            return PartialView();
        }

        [HttpPost]
        public IActionResult SendMessage(SendMessageDto model)
        {
            if(ModelState.IsValid) 
            {
                _contactUsService.TAdd(new ContactUs
                {
                    Name = model.Name,
                    Mail = model.Mail,
                    MessageBody = model.MessageBody,
                    Subject = model.Subject,
                    MessageDate = Convert.ToDateTime(DateTime.Now.ToShortDateString()),
                    MessageStatus = true
                    
                });
                return RedirectToAction("Index", "Default");
            }
            return View(model);  
               
        }







    }
}
