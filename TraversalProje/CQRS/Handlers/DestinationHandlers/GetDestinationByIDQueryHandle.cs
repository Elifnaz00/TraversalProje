using DataAccesLayer.Concrete;
using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.Office2010.ExcelAc;
using Microsoft.CodeAnalysis.CSharp.Syntax;
using System.Collections.Generic;
using System.Linq;
using TraversalProje.CQRS.Queries.DestinationQueries;
using TraversalProje.CQRS.Results.DestinationResults;

namespace TraversalProje.CQRS.Handlers.DestinationHandlers
{
    public class GetDestinationByIDQueryHandle
    {
        private readonly Context _context;
        

        public GetDestinationByIDQueryHandle(Context context)
        {
            _context = context;
        }

        public GetDestinationByIDQueryResult Handle(GetDestinationByIDQuery query)
        {
            var values = _context.Destinations.Find(query.id);
            return new GetDestinationByIDQueryResult
            {
                DestinationID = values.DestinationID,
                City = values.City,
                Daynight = values.DayNight,
                Price= values.Price,    

            };
            
             
        }
        
    }
}
