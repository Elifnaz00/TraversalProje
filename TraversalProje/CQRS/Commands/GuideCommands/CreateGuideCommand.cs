﻿using MediatR;

namespace TraversalProje.CQRS.Commands.GuideCommands
{
    public class CreateGuideCommand:IRequest
    {
        
        public string Name { get; set; }
        public string Description { get; set; }
        
        
    }
}
