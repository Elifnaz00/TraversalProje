using DataAccesLayer.Concrete;
using DocumentFormat.OpenXml.Presentation;
using DocumentFormat.OpenXml.Wordprocessing;
using MediatR;
using System.Threading;
using System.Threading.Tasks;
using TraversalProje.CQRS.Queries.DestinationQuery;
using TraversalProje.CQRS.Queries.GuideQueries;
using TraversalProje.CQRS.Results.GuideResults;

namespace TraversalProje.CQRS.Handlers.GuideHandlers
{
    public class GetGuideByIDQueryHandler : IRequestHandler<GetGuideByIDQuery, GetGuideByIDQueryResult>
    {
        public readonly Context _context;

        public GetGuideByIDQueryHandler(Context context)
        {
            _context = context;
        }

        public async Task<GetGuideByIDQueryResult> Handle(GetGuideByIDQuery request, CancellationToken cancellationToken)
        {
            var values = await _context.Guides.FindAsync(request.Id);
            return new GetGuideByIDQueryResult
            {
                GuideID = values.GuideID,
                Name = values.Name,
                Description = values.Description,
                Image= values.Image

            };
        }
    }
}
