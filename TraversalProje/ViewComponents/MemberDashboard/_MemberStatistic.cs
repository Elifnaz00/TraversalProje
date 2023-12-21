using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace TraversalProje.ViewComponents.MemberDashboard
{
    public class _MemberStatistic:ViewComponent
    {
        private readonly IGuideService _guideService;
        private readonly IDestinationService _destinationService;

        public _MemberStatistic(IGuideService guideService, IDestinationService destinationService)
        {
            _guideService = guideService;
            _destinationService = destinationService;
        }

        public IViewComponentResult Invoke()
        {
            var destinationList =_destinationService.TGetList();
            ViewBag.destination = destinationList.Count;
            var guideList= _guideService.TGetList();
            return View(guideList);
        }
    }
}
