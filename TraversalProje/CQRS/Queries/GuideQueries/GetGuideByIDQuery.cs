using MediatR;
using TraversalProje.CQRS.Handlers.GuideHandlers;
using TraversalProje.CQRS.Results.GuideResults;


namespace TraversalProje.CQRS.Queries.GuideQueries
{
    public class GetGuideByIDQuery:IRequest<GetGuideByIDQueryResult>
    {
        public GetGuideByIDQuery(int guideID)
        {
            Id = guideID;
        }

     
        public int Id { get; set; }
    }
}
