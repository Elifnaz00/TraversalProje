using DataAccesLayer.Concrete;
using EntityLayer.Concrate;
using TraversalProje.CQRS.Commands.DestinationCommands;

namespace TraversalProje.CQRS.Handlers.DestinationHandlers
{
    public class UpdateDestinationQueryHandler
    {
        private readonly Context _context;

        public UpdateDestinationQueryHandler(Context context) 
        {  
            _context = context; 
        }

        public void Handle(UpdateDestinationCommand command)
        {
            var values= _context.Destinations.Find(command.DestinationID);
            _context.Destinations.Update(new Destination
            {
                Price = command.Price,
                City = command.City,
                DayNight = command.DayNight,
                DestinationID = command.DestinationID,   
            });
            _context.SaveChanges();
            
           
        }
    }
}
