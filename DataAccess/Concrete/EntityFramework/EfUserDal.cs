﻿using Core.DataAccess;
using Core.DataAccess.EntitıFramework;
using DataAccess.Abstract;
using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace DataAccess.Concrete.EntityFramework
{
    public class EfUserDal : EfEntityRepositoryBase<User, RentCarContext>, IUserDal
    {
        
    }
}
