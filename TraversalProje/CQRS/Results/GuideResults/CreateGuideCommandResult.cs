using MediatR;
using TraversalProje.CQRS.Commands.GuideCommands;

namespace TraversalProje.CQRS.Results.GuideResults
{
    public class CreateGuideCommandResult:IRequest<CreateGuideCommand>
    {
    }
}
