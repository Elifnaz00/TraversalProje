using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using TraversalProje.CQRS.Commands.DestinationCommands;
using TraversalProje.CQRS.Handlers.DestinationHandlers;
using TraversalProje.CQRS.Queries.DestinationQueries;
using TraversalProje.CQRS.Results.DestinationResults;

namespace TraversalProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles = "Admin")]
    public class DestinationCQRSController : Controller
    {
        public readonly GetAllDestinationQueryHandler _getAllDestinationQueryHandler;
        public readonly GetDestinationByIDQueryHandle _getDestinationByIDQueryHandle;
        public readonly UpdateDestinationQueryHandler _updateDestinationQueryHandler;
        public readonly CreateDestinationCommandHandler _createDestinationCommandHandler;
        public readonly RemoveDestinationCommandHandler _removeDestinationCommandHandler;

        public DestinationCQRSController(GetAllDestinationQueryHandler getAllDestinationQueryHandler, GetDestinationByIDQueryHandle getDestinationByIDQueryHandle, UpdateDestinationQueryHandler updateDestinationQueryHandler, CreateDestinationCommandHandler createDestinationCommandHandler, RemoveDestinationCommandHandler removeDestinationCommandHandler)
        {
            _getAllDestinationQueryHandler = getAllDestinationQueryHandler;
            _getDestinationByIDQueryHandle = getDestinationByIDQueryHandle;
            _updateDestinationQueryHandler = updateDestinationQueryHandler;
            _createDestinationCommandHandler = createDestinationCommandHandler;
            _removeDestinationCommandHandler = removeDestinationCommandHandler;

        }

        public IActionResult Index()
        {
            var values= _getAllDestinationQueryHandler.Handle();
            return View(values);
        }

        [HttpGet]
        public IActionResult GetDestination(int id) 
        {
            var values= _getDestinationByIDQueryHandle.Handle(new GetDestinationByIDQuery(id));
            return View(values);
            
        }

        [HttpPost]
        public IActionResult GetDestination(UpdateDestinationCommand command)
        {

            _updateDestinationQueryHandler.Handle(command);
            return RedirectToAction("Index");

        }
        
        [HttpGet]
        public IActionResult AddDestination()
        {
            
            return View();
        }
        [HttpPost]
        public IActionResult AddDestination(CreateDestinationCommand command)
        {
            _createDestinationCommandHandler.Handle(command);
            return RedirectToAction("Index");   
        }

        
        public IActionResult DeleteDestination(int id)
        {
            _removeDestinationCommandHandler.Handle(new RemoveDestinationCommand(id));
            return RedirectToAction("Index");
        }



    }
}
