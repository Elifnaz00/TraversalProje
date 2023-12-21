﻿using EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Abstract
{
    public  interface ICommentService: IGenericServices<Comment>
    {
        List<Comment> TDestinationById(int id);
        List<Comment> TGetListCommentWithDestination();
        List<Comment> TGetListCommentWithDestinationAndUser(int id);
        
    }
    
}
