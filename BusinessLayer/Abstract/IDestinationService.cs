﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public interface IDestinationService:IGenericServices<Destination>
    {
        public Destination TGetDestinationWithGuide(int id);

        public List<Destination> TGetLast4Destinations();
    }
}
