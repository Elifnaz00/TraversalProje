using MediatR;
using Microsoft.AspNetCore.Http.Features;
using System.Collections.Generic;
using TraversalProje.CQRS.Results.GuideResults;

namespace TraversalProje.CQRS.Queries.GuideQueries
{
    public class GetAllGuideQuery:IRequest<List<GetAllGuideQueryResult>>
    {
    }
}
