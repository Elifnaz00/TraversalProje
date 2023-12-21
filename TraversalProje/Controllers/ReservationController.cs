using BusinessLayer.Abstract;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using TraversalProje.Models;

namespace TraversalProje.Controllers
{
    [AllowAnonymous]
    public class ReservationController : Controller
    {

        private readonly IDestinationService _destinationService;

        public ReservationController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IActionResult Index()
        {
            return View();
        }

        public PartialViewResult Breadcrumb()
        {
            return PartialView();
        }

      


    }
}
