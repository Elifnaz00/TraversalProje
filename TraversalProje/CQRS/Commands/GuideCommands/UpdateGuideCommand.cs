﻿using MediatR;

namespace TraversalProje.CQRS.Commands.GuideCommands
{
    public class UpdateGuideCommand: IRequest
    {
        public int GuideID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public string Image { get; set; }
    }
}
