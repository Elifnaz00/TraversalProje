using DataAccesLayer.Concrete;
using EntityLayer.Concrate;
using MediatR;
using Microsoft.AspNetCore.Http.Connections;
using Microsoft.EntityFrameworkCore.Migrations.Operations;
using System.Threading;
using System.Threading.Tasks;
using TraversalProje.CQRS.Commands.GuideCommands;
using TraversalProje.CQRS.Results.GuideResults;

namespace TraversalProje.CQRS.Handlers.GuideHandlers
{
    public class CreateGuideCommandHandler : IRequestHandler<CreateGuideCommand>
    {
        private readonly Context _context;

        public CreateGuideCommandHandler(Context context)
        {
            _context = context;
        }

        public async Task<Unit> Handle(CreateGuideCommand request, CancellationToken cancellationToken)
        {
             _context.Guides.Add(new Guide
            {
                Description = request.Description,
                Name = request.Name,
                
            });  
            await _context.SaveChangesAsync();
            return Unit.Value;
        }
    }
}
