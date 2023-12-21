using BusinessLayer.Abstract;
using EntityLayer.Concrate;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Linq;
using TraversalProje.Models;

namespace TraversalProje.ViewComponents.Reservation
{
    public class _Reservation:ViewComponent
    {
        private readonly IDestinationService _destinationService;
        

        public _Reservation(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _destinationService.TGetList().Select(p => new DestinationModel
            {
                Price = p.Price,
                City = p.City,
                Capacity = p.Capacity,
                DayNight = p.DayNight
            }).ToList();

           
            return View(values);
            
        }
    }
}
