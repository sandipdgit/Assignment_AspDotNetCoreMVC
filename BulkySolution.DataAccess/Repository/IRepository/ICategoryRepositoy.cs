﻿using BulkySolution.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BulkySolution.DataAccess.Repository.IRepository
{
    interface ICategoryRepositoy : IRepository<Category>
    {
        void Update(Category obj);
        void Save();
    }
}
